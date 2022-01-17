using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.Rtde;
using UnderAutomation.UniversalRobots.SocketCommunication;

public class Demo
{
    static void Main(string[] args)
    {
        // Create a new robot instance
        var robot = new UR();

        var parameters = new ConnectParameters("192.168.0.1");

        // Enable Primary Interface
        parameters.PrimaryInterface.Enable = true;

        // Select exchanged data
        parameters.Rtde.Enable = true;
        parameters.Rtde.Frequency = 500; // Hz
        parameters.Rtde.InputSetup.Add(RtdeInputData.InputDoubleRegisters, 42);
        parameters.Rtde.InputSetup.Add(RtdeInputData.StandardAnalogOutput0);
        parameters.Rtde.OutputSetup.Add(RtdeOutputData.ActualTcpPose);
        parameters.Rtde.OutputSetup.Add(RtdeOutputData.ActualTcpSpeed);
        parameters.Rtde.OutputSetup.Add(RtdeOutputData.ActualTcpForce);
        parameters.Rtde.OutputSetup.Add(RtdeOutputData.ActualCurrent);
        parameters.Rtde.OutputSetup.Add(RtdeOutputData.InputIntRegisters, 0);

        // Enable Dashboard commands
        parameters.Dashboard.Enable = true;

        // XML-RPC server on port 50000
        parameters.XmlRpc.Enable = true;
        parameters.XmlRpc.Port = 50000;

        // Socket server on port 50001
        parameters.SocketCommunication.Enable = true;
        parameters.SocketCommunication.Port = 50001;

        // Enable SSH commands and files
        parameters.Ssh.EnableSsh = true;
        parameters.Ssh.EnableSftp = true;
        parameters.Ssh.Username = "ur";
        parameters.Ssh.Password = "easybot";

        // Connect to the robot
        robot.Connect(parameters);


        /********************
           PRIMARY INTERFACE
        *********************/
        // Get all program and installation variables
        GlobalVariable[] variables = robot.PrimaryInterface.GlobalVariables.GetAll();
        // Send and execute script on the robot
        robot.PrimaryInterface.Send("movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)");
        // robot.PrimaryInterface.ProgramThreads...
        // robot.PrimaryInterface.PopupMessage...
        // robot.PrimaryInterface.JointData.Elbow...
        // robot.PrimaryInterface.SingularityInfo


        /********************
                 RTDE
        *********************/
        // Real frequency of received data
        var frequency = robot.Rtde.MeasuredFrequency;
        // Event raised at 500hz when data is received
        robot.Rtde.OutputDataReceived += (_, data) =>
        {
            double actualTcpPoseZ = data.OutputDataValues.ActualTcpPose.Z;
            double actualTcpPoseX = data.OutputDataValues.InputIntRegisters.X0;
        };
        // Prepare input values
        var inputs = new RtdeInputValues();
        inputs.InputDoubleRegisters.X42 = -42.1;
        inputs.StandardAnalogOutput0 = 0.5;
        // Write values to robot
        robot.Rtde.WriteInputs(inputs);


        /********************
              DASHBOARD
        *********************/
        // Power on the robot arm and release brakes
        robot.Dashboard.PowerOn();
        robot.Dashboard.ReleaseBrake();
        // Load program file to polyscope
        robot.Dashboard.LoadProgram("fast_bin_picking.urp");
        // Start the program
        robot.Dashboard.Play();
        // Display a popup on the pendant
        robot.Dashboard.ShowPopup("I just remote-controlled my robot!");


        /********************
         SOCKET COMMUNICATION
        *********************/
        // Get all client connected with URScript socket_open()
        SocketClient[] clients = robot.SocketCommunication.ConnectedClients;
        // Send message to all clients and reply "ok" when a message is received
        robot.SocketCommunication.SocketWrite("Hello :) !");
        robot.SocketCommunication.SocketRequest += (_, request) =>
        {
            string message = request.Message;
            request.Client.SocketWrite("ok");
        };


        /********************
                XML-RPC
        *********************/
        // Handle XML-RPC request sent with this kind of script :
        // rpc := rpc_factory("xmlrpc","this-pc:50000")
        // answer := rpc.GetPose("Hello", True, False, 12, 12.2, p[100, 100, 120, 0.1, 0, 0], [12, 1.2, 123])
        robot.XmlRpc.XmlRpcServerRequest += (_, request) =>
        {
            if (request.MethodName == "GetPose" && request.Arguments[0] == "Hello")
                // Return a pose to the robot script
                request.Answer = new Pose(0.1, -0.2, 0);
        };


        /********************
                  SSH
        *********************/
        // Ask robot linux controller to execute a shell command
        var command = robot.Ssh.RunCommand("ping 192.168.0.2");
        string result = command.Result;
        int exitStatus = command.ExitStatus;


        /********************
                 SFTP
        *********************/
        // List all files and directories in "programs" directory
        var items = robot.Sftp.ListDirectory("/home/ur/ursim-current/programs/");

        // Manipulates files and directories
        // robot.Sftp.DownloadFile()
        // robot.Sftp.UploadFile()
        // robot.Sftp.CreateDirectory()


        /********************
         EDIT NATIVE FILES
        *********************/
        // Manipulate and edit program and installation files
        URProgram program = URProgram.Load(@"C:\path\to\program.urp");
        URInstallation installation = URInstallation.Load(@"C:\path\to\default.installation");


        /********************
             CONVERT POSE
        *********************/
        // Convert pose types
        var pose = new Pose(0.1, 0.2, -0.1, 0.01, 0, 1.1);
        var rpy = pose.FromRotationVectorToRPY();
        var rotationVector = pose.FromRotationVectorToRPY();
    }
}




