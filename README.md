[![UnderAutomation Universal Robots communication SDK](https://underautomation.com/cover.png)](https://underautomation.com)

# Universal Robots communication SDK

This SDK (Software Development Kit) provides the ability to create customized applications that can communicate with every UR robots.

More information : [https://underautomation.com](https://underautomation.com)

## Features

### Primary and Secondary Interfaces
Send URScript commands and receive robot state data at 10Hz : Cartesian and angular position, robot status, inputs and outputs value, and 100+ more measurements ...
``` c#
ur.Send("movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)");
double x = ur.CartesianInfo.TCPOffsetX;
double shoulderSpeed = ur.JointData.Shoulder.ActualSpeed;
```

### Dashboard Server
Remote control the robot : load, play, pause, and stop a robot program, power on and off, release brake, shutdown, ...
``` c#
ur.PowerOn();
ur.ReleaseBrake();
ur.LoadProgram("prg1.urp");
ur.Play();
```

### XML-RPC
From your robot program, remote call a function implemented in your .NET program. For example, this allows you to request a position resulting from image processing.
``` ruby
# Connect to the SDK and specifie the IP and port of the PC
rpc:=rpc_factory("xmlrpc","http://192.168.0.10:50000")

# Call method GetPose and wait for the reply. The replied pose will be assigned in variable "answer"
answer:=rpc.GetPose(100)
```

``` c#
// Answer sent to the robot
ur.XmlRpcServerRequest += (o, request) =>
  {
    if(request.MethodName == "GetPose") request.Answer = new Pose(request.Arguments[0], 200, 100, 0, 0, 0);
  };
```

### SFTP
Manipulate files and folders of the robot via SFTP (Secure File Transfer Protocol) : download to the robot, import from the robot, rename, delete, move, list files in a folder...
``` c#
ur.SFTP.DownloadFile("/home/ur/ursim-current/programs/my-program.urp", content);
ur.SFTP.UploadFile(content, "/home/ur/ursim-current/programs/my-program.urp");
ur.SFTP.Delete("/home/ur/ursim-current/programs/my-program.urp");
ur.SFTP.WriteAllText("/home/ur/ursim-current/programs/file.txt", "Hello !");
```

### SSH
Open a SSH (Secure Shell) connection with the robot to execute Linux command lines, as in the terminal.
``` c#
ur.SSH.RunCommand("echo Hello > /home/ur/Desktop/NewFile.txt");
```

### Convert position types
Convert Rotation Vector to and from RPY.
``` c#
var pose = new Pose(1, 1, 0, 0.1, 0.2, -0.5);
var rpy = pose.FromRotationVectorToRPY();
var rotVect = pose.FromRPYToRotationVector();
```

## Compatibility
Compatible with all UR robots and firmwares UR3, UR5, UR10, UR16, CB-Series, e-Serie. 

Nothing to install on the robot : implemented protocols are available on your robot out of the box.

A 100% managed "UnderAutomation.UniversalRobots.dll" assembly without dependencies in the version of your choice: .NET Framework ≥3.5, .NET Standard, - .NET 5 and Core for Windows, Linux, MacOS

## Examples
Pre-built example applications with source code are provided for Winforms, .NET console, LabVIEW and Python.

## License
This SDK is a commercial library and a license *must* be purshased. Once acquired, any application you develop can be delivered to an unlimited number of customers without royalties and without recurring subscription.

More information : [https://underautomation.com](https://underautomation.com)

