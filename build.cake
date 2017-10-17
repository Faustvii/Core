var target = Argument("target", "Default");

Task("Default")
    .Does(()  => {
        DotNetBuild("./Faust.Core.sln");
    });

RunTarget(target);