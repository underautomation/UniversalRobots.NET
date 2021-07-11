Content :
* Libs : all DLL libraries
* Windows Forms Example
* Linux, Mac OS and Windows console example
* Node.js example
* Python example
* LabVIEW example

Tested with UR firwmare versions from 1.5 to 5.11

What's new :
- Add XML-RPC support : the robot can send requests to the SDK with arguments and retrieve an answer
- The Connect() method has now multiple arguments to choose which services to enable (data streaming, XML-RPC server, ping at startup)
- Rename enum UniversalRobotPorts to DataStreamingPorts
- Introduce Pose class to store pose information and convert from and to RPY / Rotation vector
- Remove .NET 2.0 support

By downloading, you hereby agree to the [terms and conditions](https://underautomation.com/eula)