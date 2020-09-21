function GetVersion()
{
    $.getJSON("https://api.github.com/repos/monkeyman192/MBINCompiler/releases").done(function (json){
        // most recent release will be first entry in list
        var release = json[0];
        if (release.assets.length === 0){
            alert('Something went wrong! Please raise an issue on GitHub!');
        }
        var version = release.tag_name;

        document.getElementById("direct_dl").innerText = "Download latest .exe (" + version + ")";
    });
}
