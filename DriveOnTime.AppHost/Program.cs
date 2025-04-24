var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DriveOnTimeUI_Web>("driveontimeui-web");

builder.Build().Run();
