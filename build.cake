var target = Argument("target", "Default");

Task("Default")
    .Does(()  => {
        DotNetCoreRestore();
        
        var settings = new DotNetCoreMSBuildSettings
        {
            NoLogo = true,
            MaxCpuCount = -1,
            ConsoleLoggerSettings = new MSBuildLoggerSettings{
                Verbosity = DotNetCoreVerbosity.Minimal
            }
        };
        DotNetCoreMSBuild(settings);
    });

RunTarget(target);