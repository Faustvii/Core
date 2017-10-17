var target = Argument("target", "Default");

Task("Restore-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() => {
        DotNetCoreRestore();
    });

Task("Clean")
    .Does(() => {
        var directoriesToClean = GetDirectories("./src/**/bin");
        foreach(var dirt in directoriesToClean){
            Information("Cleaning {0}", dirt);
        }
        CleanDirectories(directoriesToClean);
    });

Task("Default")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(()  => {
        var settings = new DotNetCoreMSBuildSettings
        {
            NoLogo = true,
            MaxCpuCount = -1,
            ConsoleLoggerSettings = new MSBuildLoggerSettings
            {
                Verbosity = DotNetCoreVerbosity.Minimal
            }
        };
        DotNetCoreMSBuild(settings);
    });

RunTarget(target);