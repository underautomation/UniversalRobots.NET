## Same code for PolyScope and PolyScope X

The new interface `IRobotDashboard` contains the commands that exist on the Dashboard Server client (PolyScope 5, CB3 and e-Series) and on the REST API client (PolyScope X): power, brakes, protective stop, safety restart, programs, robot mode, safety mode, operational mode, remote control, popups and PolyScope version. `robot.Dashboard` and `robot.Rest` implement it, so one code controls both families. Every method returns a `RobotDashboardResponse` or a `RobotDashboardResponse<T>` with `Succeed`, `Message` and `Value`.

The interface is implemented explicitly: use a variable of type `IRobotDashboard`. The methods of `robot.Dashboard` and `robot.Rest` keep their own answer types (`CommandResponse` and `RestApiResponse`).

```csharp
IRobotDashboard dashboard = isPolyScopeX ? (IRobotDashboard)robot.Rest : robot.Dashboard;

dashboard.PowerOn();
dashboard.ReleaseBrake();
dashboard.LoadProgram("my_program");
dashboard.Play();

RobotDashboardResponse<SafetyModes> safety = dashboard.GetSafetyMode();
Console.WriteLine(safety.Value);
```

## REST API: robot state, popups and program files

The REST API client of PolyScope X has new methods:

- Robot state: `GetLoadedProgram`, `GetRobotMode`, `GetSafetyMode`, `GetOperationalMode`, `IsInRemoteControl`, `GetPolyscopeVersion` and `GetRobotApiVersion`.
- Popups: `ShowPopup`, `ShowPopupWithTitle`, `ClosePopup` and `CloseSafetyPopup`.
- Program files: `GetPrograms` returns a `RestProgramInfo[]` (name, description, state, creation, modification and save dates). `UploadProgramFile` and `UploadProgramContent` add a new program, `UpdateProgramFile` and `UpdateProgramContent` replace an existing program, `DownloadProgram` and `DownloadProgramToFile` read a program.

```csharp
RestApiResponse<RobotModes> mode = robot.Rest.GetRobotMode();
RestApiResponse<SafetyModes> safety = robot.Rest.GetSafetyMode();

robot.Rest.ShowPopupWithTitle("Cell 3", "Load the parts");

foreach (RestProgramInfo program in robot.Rest.GetPrograms().Value)
    Console.WriteLine(program.Name);

robot.Rest.UploadProgramFile(@"C:\programs\pick_and_place.urpx");
robot.Rest.DownloadProgramToFile("pick_and_place", @"C:\backup\pick_and_place.urpx");
```

## Dashboard Server: safety mode, user role, resume and diagnostics

New methods of the Dashboard Server client:

- `GetSafetyMode` returns a `SafetyModes` value.
- `GetUserRole` returns the `UserRoles` value set with `SetUserRole`.
- `Resume` resumes a paused program. Only PolyScope X knows this command: on PolyScope 5, use `Play`.
- `SaveLog` saves the log of the robot to its log history file.
- `GenerateFlightReport(FlightReportTypes)` generates a flight report and returns its identifier. The SDK waits up to 3 minutes for the answer.
- `GenerateSupportFile(directory)` generates a support file in a directory of the robot and returns its name. The SDK waits up to 10 minutes for the answer.

```csharp
CommandResponse<SafetyModes> safety = robot.Dashboard.GetSafetyMode();
CommandResponse<string> report = robot.Dashboard.GenerateFlightReport(FlightReportTypes.System);
Console.WriteLine($"Flight report {report.Value}");
```

## Safety modes

The new enum `SafetyModes` lists the 21 safety modes of the robot, with `Unknown` for a value that the SDK does not know. `MasterboardData` of the Primary Interface has 3 new properties: `SafetyModeValue`, `IsProtectiveStopped` (protective, safeguard or enabling device stop) and `SafetyModeAllowsExecution` (`Normal` or `Reduced`).

The new static class `UrEnumHelper` converts the numbers sent by a robot to the enums of the SDK (`RobotModelFromValue`, `RobotModeFromValue`, `SafetyModeFromValue`, `RobotSeriesFromValue`, `ControlBoxTypeFromValue`, `ToolFlangeTypeFromValue`). An unknown number never throws: the result is the `Unknown` value of the enum. `RobotSeriesFromModel` finds the series of a robot from its model and its software version.

```csharp
var masterboard = robot.PrimaryInterface.MasterboardData;
if (masterboard.IsProtectiveStopped)
    robot.Dashboard.UnlockProtectiveStop();
```

## RTDE: software version, control box and tool flange

At connection, the RTDE client reads 3 properties of the controller: `SoftwareVersion` (for example "5.26.3"), `ControlBoxType` (`CB5` or `CB7`) and `ToolFlangeType` (`V1` or `V2`). They need PolyScope 5.26.3 or later, or PolyScope X 10.15 or later. With an older controller, `SoftwareVersion` is null and the 2 others are `Unknown`. The connection is not changed if the controller does not give them.

```csharp
robot.Connect(parameters);
Console.WriteLine($"{robot.Rtde.SoftwareVersion} {robot.Rtde.ControlBoxType} {robot.Rtde.ToolFlangeType}");
```

## UR15 and G Series

`RobotModels` has 4 new values: `UR15`, `UR10G1750`, `UR17G1300` and `UR18G950`. `GetRobotModel` of the Dashboard Server now recognizes the UR15. `RobotModels` and `RobotModes` have a new `Unknown` value. The new enum `RobotSeries` gives the series of a robot: `CB3`, `ESeries`, `URSeries` or `GSeries`.

The G Series models are not in `RobotModelsExtended`: their factory kinematic parameters are not published yet, so the kinematics of the SDK does not compute them.

## REST API fixes

- An answer of the robot with a 2xx status other than 200 is now a success. Before, `Succeed` was false.
- Program names and texts that contain quotes, backslashes or line breaks are now sent correctly, and the texts of the answers are decoded correctly.

## .NET 6 and .NET 10

The NuGet package and `UnderAutomation.UniversalRobots.zip` now contain a `net6.0` and a `net10.0` build. The package targets .NET Framework 3.5 to 4.8, .NET Standard 2.0 and 2.1, .NET Core 3.0, and .NET 5, 6, 8, 9 and 10.

## Package information

The NuGet package links to the Universal Robots page of underautomation.com, to the `UniversalRobots.NET` repository and to its release notes. It also contains `THIRD-PARTY-NOTICES.txt`, the notices of the third-party code included in the library.
