//A00274134
using Assignment.InterfaceCommand;

namespace Assignment
{
    static class RobotTester
    {
        public static void TestRobot()
        {
            int totalCommands = 1;
            Robot robot = new Robot();
            Console.WriteLine("Choose 6 Commands : \nON\nOFF\nNORTH\nSOUTH\nEAST\nSOUTH\nWEST\nREBOOT\n");
            do
            {
                Console.Write($"Choose {totalCommands} command : ");
                string? com = Console.ReadLine()?.ToUpper();
                RobotCommand? command = com switch
                {
                    "ON" => new OnCommand(),
                    "OFF" => new OffCommand(),
                    "NORTH" => new NorthCommand(),
                    "SOUTH" => new SouthCommand(),
                    "EAST" => new EastCommand(),
                    "WEST" => new WestCommand(),
                    "REBOOT" => new RebootCommand(),
                    _ => null
                };
                if (command != null)
                {
                    robot.LoadCommand(command);
                    totalCommands++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("------- Please enter valid commands only --------");
                    Console.ResetColor();
                }
            } while (totalCommands <= 6);
            Console.WriteLine();
            robot.Run();
            Console.ReadLine();
        }
    }
}
