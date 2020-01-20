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
    }
}
