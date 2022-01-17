using System;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Rtde;

class DataExchange
{
    static void Main(string[] args)
    {
        // Create a new robot instance
        var robot = new UR();

        var param = new ConnectParameters();
        param.IP = "192.168.0.1";

        // Enable primary interface to get variable values
        param.PrimaryInterface.Enable = true;

        // Enable RTDE at 5Hz (500Hz possible)
        param.Rtde.Enable = true;
        param.Rtde.Frequency = 5;

        // Ask the robot for permission to write these registers
        param.Rtde.InputSetup.Add(RtdeInputData.StandardAnalogOutput0);
        param.Rtde.InputSetup.Add(RtdeInputData.InputBitRegisters, 64);

        // Ask the robot to send me this data
        param.Rtde.OutputSetup.Add(RtdeOutputData.ActualTcpPose);
        param.Rtde.OutputSetup.Add(RtdeOutputData.ActualTcpForce);

        // Connect to the robot
        robot.Connect(param);

        var inputs = new RtdeInputValues();

        // Event raised when data is received
        robot.Rtde.OutputDataReceived += (o, e) =>
        {
            /**/
            // Display robot TCP pose
            var pose = robot.Rtde.OutputDataValues.ActualTcpPose;
            Console.WriteLine($"TCP pose : X:{pose.X}mm, Y:{pose.Y}mm, Z:{pose.Z}mm, Rx:{pose.RxDegrees}°, Ry:{pose.RyDegrees}°, Rz:{pose.Rz}°");

            // Display robot TCP force
            var force = robot.Rtde.OutputDataValues.ActualTcpForce;
            Console.WriteLine($"TCP Force : Fx:{force.X}N, Fy:{force.Y}N, Fz:{force.Z}N, Mx:{force.Rx}Nm, My:{pose.Ry}Nm, Mz:{pose.Rz}Nm");

            // Write data in robot controler
            inputs.StandardAnalogOutput0 = 0.2;
            inputs.InputBitRegisters.X64 = true;
            robot.Rtde.WriteInputs(inputs);
            /**/
        };

        // Event raised when a program or installation variable change
        robot.PrimaryInterface.GlobalVariables.ValuesUpdated += (o, e) =>
        {
            /**/
            // Display all program and installation variables
            var variables = robot.PrimaryInterface.GlobalVariables.GetAll();
            foreach (var variable in variables)
                Console.WriteLine($"{variable.Name} = {variable.Value} ({variable.Type})");
            /**/
        };

        Console.ReadLine();
    }
}
