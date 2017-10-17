var target = Argument("target", "Default");

Task("Default")
    .Does(()  => {
        DotNetCoreRestore();
        DotNetBuild("./Faust.Core.sln");
    });

RunTarget(target);