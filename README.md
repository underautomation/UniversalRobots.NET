# Universal Robots Communication SDK for .NET

[![UnderAutomation Universal Robots communication SDK](https://raw.githubusercontent.com/underautomation/UniversalRobots.NET/refs/heads/main/.github/assets/banner.png)](https://underautomation.com/universal-robots)

[![NuGet](https://img.shields.io/nuget/v/UnderAutomation.UniversalRobots?label=NuGet&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.UniversalRobots/)
[![NuGet downloads](https://img.shields.io/nuget/dt/UnderAutomation.UniversalRobots?label=Downloads&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.UniversalRobots/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-3.5+-blueviolet)](#compatibility)
[![.NET Standard](https://img.shields.io/badge/.NET_Standard-2.0_2.1-blueviolet)](#compatibility)
[![.NET](https://img.shields.io/badge/.NET-5_to_10-blueviolet)](#compatibility)
[![License](https://img.shields.io/badge/license-commercial-blue)](https://underautomation.com/universal-robots/eula)

**UnderAutomation.UniversalRobots** is a fully managed .NET SDK that communicates with Universal Robots
cobots (CB-Series, e-Series and the newer models, PolyScope and PolyScope X) through the standard
interfaces of the controller: RTDE, Primary Interface, Dashboard Server, REST API, XML-RPC, sockets,
Interpreter Mode, SSH and SFTP. It also computes the forward and inverse kinematics offline. No URCap and no
option is needed on the robot.

It works with real robots and with the URSim simulator.

- Product page: [underautomation.com/universal-robots](https://underautomation.com/universal-robots)
- Documentation: [underautomation.com/universal-robots/documentation](https://underautomation.com/universal-robots/documentation)
- Also available for [Python](https://github.com/underautomation/UniversalRobots.py), [LabVIEW](https://github.com/underautomation/UniversalRobots.vi) and [Unity](https://github.com/underautomation/UniversalRobots.Unity)

Introduction video:

https://user-images.githubusercontent.com/47540360/143318635-6d6aaaf4-5642-457a-8ff1-4322f2defe82.mp4

## What you can do

- **RTDE:** read the robot data and write inputs and registers, at up to 500 Hz. Read the software
  version, the control box and the tool flange of the controller.
- **Primary Interface:** send URScript commands, read the robot state about 10 times per second, read the
  global variables of the program.
- **Dashboard Server** (PolyScope) and **REST API** (PolyScope X): power, brakes, programs, robot and
  safety modes, popups. One interface, `IRobotDashboard`, for both. Program files of PolyScope X: list,
  upload and download.
- **XML-RPC:** answer the function calls of a URScript program from your .NET code.
- **Socket communication:** exchange messages with a URScript program.
- **Interpreter Mode:** send URScript lines to a running program.
- **SSH and SFTP:** run commands on the controller, upload, download and delete files.
- **Kinematics:** forward and inverse kinematics for every UR model, without connection.
- **Files:** read `.urp` programs, `.installation` files and archives.

## Example applications

The release page of this repository gives ready-to-run applications. Their source code is in this
repository.

### Windows Forms application

[`UnderAutomation.UniversalRobots.Showcase.Forms`](UnderAutomation.UniversalRobots.Showcase.Forms) shows every
feature of the SDK. A Visual Basic version is in
[`UnderAutomation.UniversalRobots.Showcase.Forms.vb`](UnderAutomation.UniversalRobots.Showcase.Forms.vb).

**Download:** [UnderAutomation.UniversalRobots.Showcase.Forms.exe](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Forms.exe) ([all releases](https://github.com/underautomation/UniversalRobots.NET/releases))

![Windows Forms application](https://raw.githubusercontent.com/underautomation/UniversalRobots.NET/refs/heads/main/.github/assets/desktop.jpg)

### Console application for Linux, macOS and Windows

[`UnderAutomation.UniversalRobots.Showcase.Console`](UnderAutomation.UniversalRobots.Showcase.Console) is
built for 6 platforms. Each file runs alone, without the .NET runtime installed. Use it to try the SDK on
Linux, macOS or an ARM board without writing code.

| OS | Architecture | Download |
| --- | --- | --- |
| Linux | ARM | [UnderAutomation.UniversalRobots.Showcase.Console.linux-arm](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.linux-arm) |
| Linux | x64 | [UnderAutomation.UniversalRobots.Showcase.Console.linux-x64](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.linux-x64) |
| macOS | ARM64 | [UnderAutomation.UniversalRobots.Showcase.Console.osx-arm64](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.osx-arm64) |
| macOS | x64 | [UnderAutomation.UniversalRobots.Showcase.Console.osx-x64](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.osx-x64) |
| Windows | x64 | [UnderAutomation.UniversalRobots.Showcase.Console.win-x64.exe](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.win-x64.exe) |
| Windows | x86 | [UnderAutomation.UniversalRobots.Showcase.Console.win-x86.exe](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.win-x86.exe) |

On Linux and macOS, make the file executable first (`chmod +x <file>`).

![Console application](https://raw.githubusercontent.com/underautomation/UniversalRobots.NET/refs/heads/main/.github/assets/console.png)

## Installation

```bash
dotnet add package UnderAutomation.UniversalRobots
```

Or with the NuGet Package Manager console:

```
Install-Package UnderAutomation.UniversalRobots
```

You can also download [UnderAutomation.UniversalRobots.zip](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.zip)
from the [releases page](https://github.com/underautomation/UniversalRobots.NET/releases). It contains one
folder per target framework. On Windows, unblock the zip file before you extract it (right-click,
"Properties", "Unblock"), then reference the DLL of your framework.

## Getting started

```csharp
using UnderAutomation.UniversalRobots;

// The SDK runs in trial mode for 30 days. Register your key to remove the trial limit.
UR.RegisterLicense("Your Company", "your-license-key");

var robot = new UR();

var parameters = new ConnectParameters("192.168.0.1");
parameters.Dashboard.Enable = true;
parameters.PrimaryInterface.Enable = true;

robot.Connect(parameters);

Console.WriteLine(robot.Dashboard.GetRobotMode().Value);

robot.Disconnect();
```

Enable only the interfaces you need in `ConnectParameters`: `Rtde`, `PrimaryInterface`, `Dashboard`,
`Rest`, `XmlRpc`, `SocketCommunication`, `InterpreterMode`, `Ssh`.

## Features

### Real-Time Data Exchange (RTDE)

Read the robot data and write inputs at up to 500 Hz.

```csharp
var robot = new UR();

var parameters = new ConnectParameters("192.168.0.1");
parameters.Rtde.Enable = true;
parameters.Rtde.Frequency = 500; // Hz

// Data written to the controller
parameters.Rtde.InputSetup.Add(RtdeInputData.StandardAnalogOutput0);
parameters.Rtde.InputSetup.Add(RtdeInputData.InputIntRegisters, 0);

// Data sent by the robot
parameters.Rtde.OutputSetup.Add(RtdeOutputData.ActualTcpPose);
parameters.Rtde.OutputSetup.Add(RtdeOutputData.ToolOutputVoltage);
parameters.Rtde.OutputSetup.Add(RtdeOutputData.OutputDoubleRegisters, 10);

robot.Connect(parameters);

// Raised for each sample
robot.Rtde.OutputDataReceived += (sender, e) =>
    Console.WriteLine(robot.Rtde.OutputDataValues.ActualTcpPose);

// Write inputs
var inputValues = new RtdeInputValues();
inputValues.StandardAnalogOutput0 = 0.2;
inputValues.InputIntRegisters.X0 = 12;
robot.Rtde.WriteInputs(inputValues);
```

### Primary Interface

Send URScript commands and read the robot state about 10 times per second.

```csharp
robot.PrimaryInterface.Script.Send("movej([-1.5,-1.5,-2,-0.5,1.8,0], a=1.4, v=1.05)");

double x = robot.PrimaryInterface.CartesianInfo.TCPOffsetX;
double shoulderSpeed = robot.PrimaryInterface.JointData.Shoulder.ActualSpeed;

// Global variables of the running program
GlobalVariable myVar = robot.PrimaryInterface.GlobalVariables.GetByName("myVar");
GlobalVariable[] variables = robot.PrimaryInterface.GlobalVariables.GetAll();
```

### Remote control

Power, brakes, programs, robot and safety modes.

```csharp
// PolyScope: Dashboard Server
robot.Dashboard.PowerOn();
robot.Dashboard.ReleaseBrake();
robot.Dashboard.LoadProgram("prg1.urp");
robot.Dashboard.Play();

// PolyScope X: REST API
robot.Rest.PowerOn();
robot.Rest.BrakeRelease();
robot.Rest.LoadProgram("prg1");
robot.Rest.Play();
```

The two clients implement `IRobotDashboard`. Write the code once for PolyScope and PolyScope X:

```csharp
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Common;

bool isPolyScopeX = true;

var robot = new UR();
var parameters = new ConnectParameters("192.168.0.1");
parameters.Dashboard.Enable = !isPolyScopeX;
parameters.Rest.Enable = isPolyScopeX;
robot.Connect(parameters);

IRobotDashboard dashboard = isPolyScopeX ? (IRobotDashboard)robot.Rest : robot.Dashboard;

dashboard.PowerOn();
dashboard.ReleaseBrake();
dashboard.LoadProgram("prg1");
dashboard.Play();

RobotDashboardResponse<SafetyModes> safety = dashboard.GetSafetyMode();
Console.WriteLine(safety.Value);

robot.Disconnect();
```

On PolyScope X, the REST API client also reads and writes the program files:

```csharp
foreach (RestProgramInfo program in robot.Rest.GetPrograms().Value)
    Console.WriteLine(program.Name);

robot.Rest.UploadProgramFile(@"C:\programs\pick_and_place.urpx");
robot.Rest.DownloadProgramToFile("pick_and_place", @"C:\backup\pick_and_place.urpx");
```

### Forward and inverse kinematics

Computes the joint positions of a Cartesian pose, and the reverse, with an analytical algorithm. No
connection is needed.

```csharp
// Default DH parameters of a UR3e
IUrDhParameters dhParameters = KinematicsUtils.GetDhParametersFromModel(RobotModelsExtended.UR3e);

// Forward kinematics, joint angles in radians
KinematicsResult fkResult = KinematicsUtils.ForwardKinematics(new double[] { 0, -1.57, 1.57, 0, 0, 0 }, dhParameters);

// Inverse kinematics of a pose (x, y, z in m, rotation vector in rad)
var pose = new Pose(0.3, 0.1, 0.4, 0, 3.14, 0);
double[][] ikSolutions = KinematicsUtils.InverseKinematics(pose.FromRotationVectorTo4x4Matrix(), dhParameters);
```

### XML-RPC: call .NET functions from URScript

The URScript program calls a function:

```ruby
rpc := rpc_factory("xmlrpc", "http://192.168.0.10:50000")
answer := rpc.GetPose(100)
```

Your .NET code answers:

```csharp
robot.XmlRpc.XmlRpcServerRequest += (o, request) =>
{
    if (request.MethodName == "GetPose") request.Answer = new Pose(request.Arguments[0], 200, 100, 0, 0, 0);
};
```

### Socket communication

Exchange messages with a URScript program.

```csharp
robot.SocketCommunication.SocketWrite("Hello, Robot!");
robot.SocketCommunication.SocketRequest += (sender, e) => Console.WriteLine(e.Message);
```

### SFTP

Upload, download and delete files on the controller.

```csharp
robot.Sftp.UploadFile("my-program.urp", "/programs/my-program.urp");
robot.Sftp.Delete("/programs/old-program.urp");
```

### SSH

Run shell commands on the controller.

```csharp
robot.Ssh.RunCommand("echo 'Hello' > /home/ur/Desktop/NewFile.txt");
```

## Shell sources

The folder [`UnderAutomation.UniversalRobots.ObfuscatedSources`](UnderAutomation.UniversalRobots.ObfuscatedSources)
contains every public type and member of the SDK, with its XML documentation. The bodies of the methods
are replaced by "Source is hidden". Use it to:

- browse the public API and its documentation on GitHub;
- jump to a definition from your code editor;
- see the structure of the code that is delivered with a source license.

The source license gives the complete source code of the library, with the Visual Studio solution. See
the [license page](https://underautomation.com/universal-robots/documentation/license) of the documentation.

## Compatibility

| Target framework | Supported |
| --- | --- |
| .NET 10.0 / 9.0 / 8.0 / 6.0 / 5.0 | yes |
| .NET Core 3.0 | yes |
| .NET Standard 2.1 / 2.0 | yes |
| .NET Framework 4.0 to 4.8 | yes |
| .NET Framework 3.5 | yes |

- **Operating systems:** Windows, Linux, macOS.
- **No native dependency**, no NuGet dependency (except `System.Text.Encoding.CodePages` for .NET Standard 2.0).
- **Robots:** UR3, UR5, UR10 (CB-Series), UR3e, UR5e, UR7e, UR10e, UR12e, UR16e (e-Series), UR8 Long, UR15,
  UR18, UR20, UR30, with PolyScope or PolyScope X, and URSim.

## License

This SDK needs a commercial license. A 30-day trial starts at the first use, no key needed.

- License agreement: [underautomation.com/universal-robots/eula](https://underautomation.com/universal-robots/eula) and [License.md](License.md)
- Trial, license key and source license: [underautomation.com/universal-robots/documentation/license](https://underautomation.com/universal-robots/documentation/license)
- Prices and quote: [underautomation.com/universal-robots](https://underautomation.com/universal-robots)

## Support

- Documentation: [underautomation.com/universal-robots/documentation](https://underautomation.com/universal-robots/documentation)
- Issues: [GitHub Issues](https://github.com/underautomation/UniversalRobots.NET/issues)
- Contact: [underautomation.com/contact](https://underautomation.com/contact)
