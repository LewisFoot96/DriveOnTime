var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DriveOnTimeUI_Web>("driveontimeui-web");

//builder.AddMobileProject("mauiclient", "../DriveOnTimeUI/DriveOnTimeUI");

builder.Build().Run();
