using System;
using UnderAutomation.UniversalRobots;

class RemoteControl
{
    static void Main(string[] args)
    {
        /**/
        // Create a new robot instance
        var robot = new UR();

        // Connect to the robot
        robot.Connect("192.168.0.1");

        // Power on the robot arm and release brakes
        robot.Dashboard.PowerOn();
        robot.Dashboard.ReleaseBrake();

        // Load program file to polyscope
        robot.Dashboard.LoadProgram("fast_bin_picking.urp");

        // Start the program
        robot.Dashboard.Play();

        // Get program name and state
        var state = robot.Dashboard.GetProgramState();
        Console.WriteLine($"Program name : {state.Value.Name}");
        Console.WriteLine($"Stopped, Playing or Paused ? : {state.Value.State}");

        // Display a popup on the pendant
        robot.Dashboard.ShowPopup("I just remote-controlled my robot!");
        /**/
    }
}
