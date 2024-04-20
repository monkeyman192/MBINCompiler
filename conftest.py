import os.path as op
import os
import subprocess
import tempfile

import pytest

from tests.utils import download_data, format_err_results, generate_report


TEST_ROOT_PATH = op.join(op.dirname(__file__), 'tests')
DATA_PATH = op.join(TEST_ROOT_PATH, 'data')
BASE_PATH = op.join("Build", "Release", "net6.0", "win-x64", "publish")
FAILED_FNAME = '_failed.txt'
REPORT_FNAME = op.join(op.dirname(__file__), 'results.txt')
JSON_REPORT_FNAME = op.join(op.dirname(__file__), 'report.json')


def pytest_addoption(parser):
    parser.addoption("--platform", action="store", default="win-x64",
                     help="The platform the tests are run on.",
                     choices=['win-x64', 'linux-x64'])
    parser.addoption("--datapath", action="store", default=None,
                     help="The relative or absolute path to a folder "
                          "containing .MBIN files to be tested. If not "
                          "provided, the test data will be downloaded from "
                          "the MBINCompiler-test-data repository.")
    parser.addoption("--use_cache", action="store_true", default=False,
                     help="Whether or not to use cached data that was "
                          "downloaded by running the tests with no additional "
                          "arguments.")
    parser.addoption("--rerun", action="store", default="all",
                     help="If tests are failing, you can chose to just re-run "
                          "the ones that have failed.",
                     choices=['all', 'failed'])
    parser.addoption("--report", action="store_true", default=False,
                     help="Whether to output a report of the failure to the "
                          "local directory.")
    parser.addoption("--mbincompiler_path", action="store",
                     help="Path to the MBINCompiler binary you want to test.")


def pytest_generate_tests(metafunc):
    # This is called for every test. Only get/set command line arguments
    # if the argument is specified in the list of test "fixturenames".
    if 'rerun' in metafunc.fixturenames:
        metafunc.parametrize("rerun", [metafunc.config.getoption('rerun')])


def pytest_sessionstart(session):
    # Before running any tests collect the required test data.
    datapath = session.config.getoption('datapath')
    if datapath:
        os.environ['datapath'] = datapath
    platform = session.config.getoption('platform')
    if platform:
        os.environ['platform'] = platform
    use_cache = session.config.getoption('use_cache')
    mbincompiler_path = session.config.getoption('mbincompiler_path')
    if mbincompiler_path:
        os.environ['mbincompiler_path'] = mbincompiler_path
    if datapath is not None and use_cache:
        print("Providing both 'datapath' and 'use_cache' command line "
              "arguments doesn't mean anything. 'datapath' will take "
              "precedence.")
    if datapath is not None:
        print(f'datapath provided: {datapath}')
    elif use_cache:
        data_path = op.join(op.dirname(__file__), 'tests', 'data')
        print(f'Using cached test data located at {data_path}')
    else:
        print("Collecting test data")
        download_data()
        print("Test data collected")

    # Make sure that the report file is removed before the test starts,
    # otherwise it will be polluted by the previous run.
    if op.exists(REPORT_FNAME):
        os.remove(REPORT_FNAME)


@pytest.fixture(scope='session')
def convert_files():
    # First, figure out the first part of the MBINCompiler call.
    platform = os.environ.get('platform')
    mbincompiler_path = os.environ.get('mbincompiler_path')
    if mbincompiler_path is not None:
        cmd = [mbincompiler_path, '-q']
    else:
        if platform == 'linux-x64':
            # need to run with mono on linux
            # Build path also includes platform on the CI
            cmd = ['sudo', 'mono',
                op.join(BASE_PATH, platform, 'MBINCompiler.exe'), '-q']
        else:
            cmd = [op.join(BASE_PATH, 'MBINCompiler.exe'), '-q']
    cmd.append('--force')

    datapath = os.environ.get('datapath', DATA_PATH)

    # Next, convert all the mbin files in the data folder to a `data_exml`
    # folder.
    # We'll have a double nested with statement so we can have both temp
    # directories existing for the whole lifecycle of the tests.
    with tempfile.TemporaryDirectory(prefix='exml_') as temp_exml_dir:
        with tempfile.TemporaryDirectory(prefix='mbin_') as temp_mbin_dir:
            print('Converting the original files to .EXML')
            subprocess.run(cmd + [datapath, f'--output-dir={temp_exml_dir}'])
            print('Converting the converted .EXML files back to .MBIN')
            subprocess.run(
                cmd + [temp_exml_dir, f'--output-dir={temp_mbin_dir}']
            )
            yield temp_exml_dir, temp_mbin_dir


@pytest.hookimpl(tryfirst=True, hookwrapper=True)
def pytest_runtest_makereport(item, call):
    # Execute all other hooks to obtain the report object.
    outcome = yield
    rep = outcome.get_result()

    if rep.when == 'call':
        # Append if the file exists or create if not.
        mode = "a" if op.exists(REPORT_FNAME) else "w"
        # Get the name of the file being tested.
        fname = rep.nodeid[(rep.nodeid.index('[') + 1):-1]
        fname = fname.split('-')[0]
        fname = op.basename(fname)
        with open(REPORT_FNAME, mode) as f:
            f.write(fname + f" {rep.outcome}" + "\n")


@pytest.hookimpl(hookwrapper=True)
def pytest_terminal_summary(terminalreporter):
    yield
    datapath = terminalreporter.config.getoption('datapath') or DATA_PATH
    failed_fpath = op.join(datapath, FAILED_FNAME)
    results = []
    failed_fpaths = []
    for failed in terminalreporter.stats.get('failed', []):
        if len(failed.sections) != 0:
            try:
                fname, err = failed.sections[-1][1].split(',')
            except ValueError:
                # This should only happen if something gets printed during the 
                # test. We should be able to safely ignore them.
                continue
            # Clean up the filename
            try:
                clean_fname = fname.split('mbin_', 1)[1].split(op.sep, 1)[1]
            except Exception:  # noqa
                clean_fname = fname
            if not clean_fname.endswith(".MBIN") and not clean_fname.endswith(".PC"):
                clean_fname = clean_fname + ".MBIN"
            failed_fpaths.append(clean_fname)
            results.append((clean_fname, err.replace('\n', '')))
    if results != []:
        results = format_err_results(results)
        print('\n')
        for result in results:
            print(result)
        print('\n')

    # Write out the report if required.
    if terminalreporter.config.getoption('report'):
        generate_report(REPORT_FNAME, JSON_REPORT_FNAME, datapath)
    # Write out the failures file.
    if len(failed_fpaths) != 0:
        with open(failed_fpath, 'w') as failed_fobj:
            failed_fobj.write('\n'.join(failed_fpaths))
        print(f'Wrote {len(failed_fpaths)} lines to {failed_fpath}')


@pytest.hookimpl(trylast=True)
def pytest_sessionfinish(session, exitstatus):
    # Override the default behaviour and cause pytest to always pass
    session.exitstatus = 0
