using System;
using UnderAutomation.UniversalRobots;

namespace ConsoleWindowsLinuxMac
{
    class Program
    {
        private static UR _ur;

        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.ResetColor();

                // If you have a license key, please put it here
                UR.RegisterLicense(licensee: null, key: null);

                Console.WriteLine(" _   _       _                          _  ______      _           _        ");
                Console.WriteLine("| | | |     (_)                        | | | ___ \\    | |         | |       ");
                Console.WriteLine("| | | |_ __  ___   _____ _ __ ___  __ _| | | |_/ /___ | |__   ___ | |_ ___  ");
                Console.WriteLine("| | | | '_ \\| \\ \\ / / _ \\ '__/ __|/ _` | | |    // _ \\| '_ \\ / _ \\| __/ __| ");
                Console.WriteLine("| |_| | | | | |\\ V /  __/ |  \\__ \\ (_| | | | |\\ \\ (_) | |_) | (_) | |_\\__ \\ ");
                Console.WriteLine(" \\___/|_| |_|_| \\_/ \\___|_|  |___/\\__,_|_| \\_| \\_\\___/|_.__/ \\___/ \\__|___/ ");
                Console.WriteLine(" _____                       _        _____                          _      ");
                Console.WriteLine("/  __ \\                     | |      |  ___|                        | |     ");
                Console.WriteLine("| /  \\/ ___  _ __  ___  ___ | | ___  | |____  ____ _ _ __ ___  _ __ | | ___ ");
                Console.WriteLine("| |    / _ \\| '_ \\/ __|/ _ \\| |/ _ \\ |  __\\ \\/ / _` | '_ ` _ \\| '_ \\| |/ _ \\");
                Console.WriteLine("| \\__/\\ (_) | | | \\__ \\ (_) | |  __/ | |___>  < (_| | | | | | | |_) | |  __/");
                Console.WriteLine(" \\____/\\___/|_| |_|___/\\___/|_|\\___| \\____/_/\\_\\__,_|_| |_| |_| .__/|_|\\___|");
                Console.WriteLine("                                                              | |           ");
                Console.WriteLine("                                                              |_|           ");
                Console.WriteLine();

                Console.WriteLine(UR.LicenseInfo.ToString());
                Console.WriteLine();

                Console.Write("Please enter robot IP or hostname : ");
                var ip = Console.ReadLine();

                _ur = new UR();
                _ur.CartesianInfoReceived += CartesianInfoReceived;
                _ur.XmlRpcServerRequest += XmlRpcServerRequest;

                _ur.Connect(ip);

                Console.WriteLine("Connecting...");
                Console.ReadKey();

                _ur.Disconnect();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        private static DateTime _lastReceived = DateTime.Now;

        private static void CartesianInfoReceived(object sender, CartesianInfoPackageEventArgs e)
        {
            // Clear console and display cartesian info every 200ms

            if ((DateTime.Now - _lastReceived).TotalMilliseconds < 200) return;
             _lastReceived = DateTime.Now;

            Console.Clear();
            Console.WriteLine($"X = {e.X.ToString("0.00")}mm");
            Console.WriteLine($"Y = {e.Y.ToString("0.00")}mm");
            Console.WriteLine($"Z = {e.Z.ToString("0.00")}mm");
            Console.WriteLine($"RX = {e.Rx.ToString("0.00")}°");
            Console.WriteLine($"RY = {e.Ry.ToString("0.00")}°");
            Console.WriteLine($"RZ = {e.Rz.ToString("0.00")}°");
            Console.WriteLine("Press any key to close...");
        }

        // Method called when the robot sends a request
        // You shoud execute on your robot : rpc:=rpc_factory("xmlrpc","http://192.168.0.10:50000")
        // Replace the IP address 192.168.0.10 with the IP of the machine running this .NET code
        // If you don't know your IP, you can find it in your interface properties or in with this SDK in the property : ur.DataStreamingLocalEndPoint
        // Use xml_rpc_sample.urp program to test this feature
        private static void XmlRpcServerRequest(object sender, XmlRpcEventArg request)
        {
            Console.WriteLine("Robot IP : " + request.EndPoint.Address);
            // Prints :
            // Robot IP : 192.168.0.1

            // Set the returned answer according to the method and its arguments
            switch (request.MethodName)
            {
                case "get_answer":
                    // Robot script : answer1:=rpc.get_answer("Hello", True, False, 12, 12.2, p[100,100,120,0.1,0,0], [12,1.2,123])
                    // Reply : answer1:=TRUE    

                    foreach (var argument in request.Arguments)
                    {
                        Console.WriteLine(argument.ToString()); // Prints argument value : "Hello", "true", "false", "12", ...
                    }

                    request.Answer = true;
                    break;

                case "GetPose":
                    // Robot script : answer2:=rpc.GetPose()
                    // Reply : answer2:=p[100,200,100,0,0,0]                    
                    request.Answer = new Pose(100, 200, 100, 0, 0, 0);
                    break;

                case "HowAreYou":
                    // Robot script : answer3:=rpc.HowAreYou("Alfred")
                    // Reply : answer3:="Fine thx Alfred"                    
                    request.Answer = "Fine thx " + request.Arguments[0];
                    break;

                case "SumFirstArray":
                    // Robot script : answer4:=rpc.SumFirstArray([1,3.5,-2])
                    // Reply : answer4:=2.5                    
                    double[] argument1 = request.Arguments[0];

                    double sum1 = 0;
                    for (int i = 0; i < argument1.Length; i++) sum1 += argument1[i];

                    request.Answer = sum1;

                    break;

                case "SumMyArguments":
                    // Robot script : answer5:=rpc.SumMyArguments(1,3.5,-2)
                    // Reply : answer5:=2.5                    
                    double sum = 0;
                    for (int i = 0; i < request.Arguments.Length; i++)
                    {
                        double argValue = request.Arguments[i];
                        sum += argValue;
                    }

                    request.Answer = sum;
                    break;

                default:
                    // Do not reply and the answer variable is not assigned
                    break;
            }
        }
    }
}
