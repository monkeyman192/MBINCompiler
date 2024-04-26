import os.path as op
import os

import pytest

from utils import compare_mbins, failed_files


DATA_PATH = op.join(op.dirname(__file__), 'data')
TO_EXML_FAIL = 'Failed conversion to EXML'
TO_MBIN_FAIL = 'Failed conversion to MBIN'


def pytest_generate_tests(metafunc):
    """ Generate a parameterization that contains the list of all the files
    that need to be tested. Ie. every file in the ./data folder.
    """
    datapath = os.environ.get('datapath', DATA_PATH)
    # If we want to only rerun the failed tests, return only that list
    if metafunc.config.getoption('rerun') == 'failed':
        fpaths = failed_files(datapath)
    else:
        # Otherwise, collect the file list as normal
        fpaths = list()
        for root, _, files in os.walk(datapath):
            for fname in files:
                fname_, ext = op.splitext(fname)
                if ext == '.MBIN':
                    fpaths.append(op.relpath(op.join(root, fname_), datapath))
    metafunc.parametrize("fname", fpaths)


def test_compare(convert_files, fname):
    """ Run the comparison test on a file.
    This test is parameterised by fpath which will contain the paths of all
    .MBIN files in the ./data directory.
    """
    converted_exml_dir, converted_mbin_dir = convert_files
    converted_exml = op.join(converted_exml_dir, fname + '.EXML')
    converted_mbin = op.join(converted_mbin_dir, fname + '.MBIN')
    if not op.exists(converted_exml):
        # If the .EXML file doesn't exist, fail.
        print(f'{fname},{TO_EXML_FAIL}')
        pytest.fail()
    elif not op.exists(converted_mbin):
        # If the .MBIN file doesn't exist, fail.
        print(f'{fname},{TO_MBIN_FAIL}')
        pytest.fail()
    else:
        # Otherwise, do a comparison of the original and final .MBIN files
        datapath = os.environ.get('datapath', DATA_PATH)
        assert compare_mbins(op.join(datapath, fname + '.MBIN'), converted_mbin)
