# Universal Robots Communication SDK

[![UnderAutomation Universal Robots communication SDK](https://raw.githubusercontent.com/underautomation/UniversalRobots.NET/refs/heads/main/.github/assets/banner.png)](https://underautomation.com)

[![NuGet](https://img.shields.io/nuget/dt/UnderAutomation.UniversalRobots?label=NuGet%20Downloads&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.UniversalRobots/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-3.5+-blueviolet)](#)
[![.NET Standard](https://img.shields.io/badge/.NET_Standard-2.0+-blueviolet)](#)
[![.NET Core](https://img.shields.io/badge/.NET_Core-2.0+-blueviolet)](#)
[![.NET Versions](https://img.shields.io/badge/.NET-5_6_8_9-blueviolet)](#)

### 🤖 Effortlessly Communicate with Universal Robots

The **Universal Robots SDK** enables seamless integration with Universal Robots for automation, data exchange, and remote control. Ideal for industrial automation, research, and advanced robotics applications.

🔗 **More Information:** [https://underautomation.com/universal-robots](https://underautomation.com/universal-robots)  
🔗 Also available for **[🟨 LabVIEW](https://github.com/underautomation/UniversalRobots.vi)** & **[🐍 Python](https://github.com/underautomation/UniversalRobots.py)** & [🧊 Unity](https://github.com/underautomation/UniversalRobots.Unity)

---

[⭐ Star if you like it !](https://github.com/underautomation/UniversalRobots.NET/stargazers)

[👁️ Watch to be notified of latest updates !](https://github.com/underautomation/UniversalRobots.NET/watchers)

---

## 🚀 TL;DR (Too Long; Didn’t Read)

✔️ **Full RTDE Support** – Read & write at up to **500Hz**  
✔️ **Send URScript Commands** – Control robots in real-time  
✔️ **Dashboard Server** – Manage power, programs, and states  
✔️ **Secure Connections** – SSH & SFTP support  
✔️ **Multi-Platform** – Works on Windows, Linux, and macOS  
✔️ **Commercial License** – Deploy with no royalties

📹 **Watch Introduction Video**

https://user-images.githubusercontent.com/47540360/143318635-6d6aaaf4-5642-457a-8ff1-4322f2defe82.mp4

---

## 📥 Download Example Applications

Explore the **Universal Robots SDK** with fully functional example applications and precompiled binaries for various platforms. [See Github releases](https://github.com/underautomation/UniversalRobots.NET/releases)

### 🔹 Windows Forms Application (Full Feature Showcase)

A Windows Forms application demonstrating all the features of the library.

📌 **Download:** [📥 UnderAutomation.UniversalRobots.Showcase.Forms.exe](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Forms.exe)

<p align="center">
<img src="https://raw.githubusercontent.com/underautomation/UniversalRobots.NET/refs/heads/main/.github/assets/desktop.jpg" alt="UnderAutomation.UniversalRobots.Showcase.Console"/>
</p>

---

### 🔹 Console Applications (Multi-Platform)

Precompiled console applications showcasing compilation for multiple operating systems.

📌 **Downloads:**

<img src="https://raw.githubusercontent.com/underautomation/UniversalRobots.NET/refs/heads/main/.github/assets/console.png" alt="UnderAutomation.UniversalRobots.Showcase.Console" align="right"/>

| OS            | Architecture | Download                                                                                                                                                    |
| ------------- | ------------ | ----------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🐧 **Linux**  | ARM          | [📥 Download](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.linux-arm)   |
| 🐧 **Linux**  | x64          | [📥 Download](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.linux-x64)   |
| 🍏 **macOS**  | ARM64        | [📥 Download](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.osx-arm64)   |
| 🍏 **macOS**  | x64          | [📥 Download](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.osx-x64)     |
| 🖥 **Windows** | x64          | [📥 Download](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.win-x64.exe) |
| 🖥 **Windows** | x86          | [📥 Download](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.Showcase.Console.win-x86.exe) |

---

## 📌 Features

### 🔹 Real-Time Data Exchange (RTDE)

Communicate with your robot at **500Hz**, read live data, and control its behavior.

```csharp
var robot = new UR();

var param = new ConnectParameters("192.168.0.1");

// Enable RTDE
param.Rtde.Enable = true;

// Exchange data at 500Hz
param.Rtde.Frequency = 500;

// Select data you want to write in robot controller
param.Rtde.InputSetup.Add(RtdeInputData.StandardAnalogOutput0);
param.Rtde.InputSetup.Add(RtdeInputData.InputIntRegisters, 0);

// Select data you want the robot to send
param.Rtde.OutputSetup.Add(RtdeOutputData.ActualTcpPose);
param.Rtde.OutputSetup.Add(RtdeOutputData.ToolOutputVoltage);
param.Rtde.OutputSetup.Add(RtdeOutputData.OutputDoubleRegisters, 10);

// Connect to robot
robot.Connect(param);

// Be notified at 500Hz when data is received
robot.Rtde.OutputDataReceived += Rtde_OutputDataReceived;

// Write input values in robot
var inputValues = new RtdeInputValues();
inputValues.StandardAnalogOutput0 = 0.2;
inputValues.InputIntRegisters.X0 = 12;
robot.Rtde.WriteInputs(inputValues);
```

### 🔹 Primary Interface

Send URScript commands and monitor robot state at **10Hz**.

```csharp
// Send script
robot.PrimaryInterface.Script.Send("movej([-1.5,-1.5,-2,-0.5,1.8,0], a=1.4, v=1.05)");

// Get data
double x = robot.PrimaryInterface.CartesianInfo.TCPOffsetX;
double shoulderSpeed = robot.PrimaryInterface.JointData.Shoulder.ActualSpeed;

// Read program variables
GlobalVariable myVar = robot.PrimaryInterface.GlobalVariables.GetByName("myVar");
GlobalVariable[] variables =  robot.PrimaryInterface.GlobalVariables.GetAll();
```

### 🔹 Dashboard Server – Remote Robot Control

Manage power, brakes, program execution, and more.

```csharp
robot.Dashboard.PowerOn();
robot.Dashboard.ReleaseBrake();
robot.Dashboard.LoadProgram("prg1.urp");
robot.Dashboard.Play();
```

### 🔹 Inverse Kinematics - Forward Kinematics

Calculates joint positions corresponding to a cartesian position and vice versa. Uses a purely algebraic and optimized algorithm.

```csharp
// Get default DH parameters for UR3e robot model²
IUrDhParameters dhParameters = KinematicsUtils.GetDhParametersFromModel(RobotModelsExtended.UR3e);

// Calculate forward kinematics for given joint angles in radians
KinematicsResult fkResult = KinematicsUtils.ForwardKinematics(new double[] { 0, -1.57, 1.57, 0, 0, 0 }, dhParameters);

// Calculate inverse kinematics for given cartesian pose
var matrix = vectorPose.FromRotationVectorTo4x4Matrix();
double[][] ikSolutions = KinematicsUtils.InverseKinematics(matrix, dhParameters);
```

### 🔹 XML-RPC – Call .NET Functions from URScript

Enable remote function calls from your robot program.

```ruby
rpc := rpc_factory("xmlrpc", "http://192.168.0.10:50000")
answer := rpc.GetPose(100)
```

```csharp
// Answer sent to the robot
robot.XmlRpc.XmlRpcServerRequest += (o, request) =>
  {
    if(request.MethodName == "GetPose") request.Answer = new Pose(request.Arguments[0], 200, 100, 0, 0, 0);
  };
```

### 🔹 Socket Communication

Allow robots to send and receive custom data via sockets.

```csharp
robot.SocketCommunication.SocketWrite("Hello, Robot!");
robot.SocketCommunication.SocketRequest += (sender, e) => Console.WriteLine(e.Message);
```

### 🔹 Secure File Transfer (SFTP)

Upload, download, and manage files securely on your robot.

```csharp
robot.Sftp.UploadFile(content, "/home/ur/ursim/programs/my-program.urp");
robot.Sftp.Delete("/home/ur/ursim/programs/old-program.urp");
```

### 🔹 SSH – Run Terminal Commands

Execute shell commands remotely.

```csharp
robot.Ssh.RunCommand("echo 'Hello' > /home/ur/Desktop/NewFile.txt");
```

---

## 🛠 Installation

### 1️⃣ **Get the SDK**

Choose the installation method that works best for you:

| Method             | NuGet (Recommended)                                                                               | Direct Download                                                                                                                        |
| ------------------ | ------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- |
| **How to Install** | Install via NuGet. [See on Nuget](https://www.nuget.org/packages/UnderAutomation.UniversalRobots) | Download and reference the DLL manually                                                                                                |
|                    | `dotnet add package UnderAutomation.UniversalRobots `                                             | 📥 [Download ZIP](https://github.com/underautomation/UniversalRobots.NET/releases/latest/download/UnderAutomation.UniversalRobots.zip) |

### 2️⃣ **Reference the SDK in Your Code**

```csharp
using UnderAutomation.UniversalRobots;
```

### 3️⃣ **Connect to Your Robot**

```csharp
var robot = new UR();
robot.Connect(new ConnectParameters("192.168.0.1"));
```

---

## 🔍 Compatibility

✅ **Supported Robots:** UR3, UR5, UR10, UR16, UR20, UR30, CB-Series, e-Series, Polyscope, Polyscope X  
✅ **Operating Systems:** Windows, Linux, macOS  
✅ **.NET Versions:** .NET Framework (≥3.5), .NET Standard, .NET Core, .NET 5/6/8/9

---

## 📢 Contributing

We welcome contributions! Feel free to:

- Report issues via [GitHub Issues](https://github.com/underautomation/UniversalRobots/issues)
- Submit pull requests with improvements
- Share feedback & feature requests

---

## 📜 License

**⚠️ This SDK requires a commercial license.**  
🔗 Learn more: [UnderAutomation Licensing](https://underautomation.com/universal-robots/eula)

---

## 📬 Need Help?

If you have any questions or need support:

- 📖 **Check the Docs**: [Documentation](https://underautomation.com/universal-robots/documentation)
- 📩 **Contact Us**: [Support](https://underautomation.com/contact)
