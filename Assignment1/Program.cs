using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {


                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = MainMenu();
                }
            }
            public static bool MainMenu()
            {


            Console.Clear();

                Console.WriteLine("Welcome! please choose a command:");
                Console.WriteLine("Press 1 to modify vehicles");
                Console.WriteLine("Press 2 to modify inventory");
                Console.WriteLine("Press 3 to modify repair");
                Console.WriteLine("Press 4 to exit program");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        goVehicles();
                        return true;
                    case "2":
                        goInventory();
                        return true;
                    case "3":
                        goRepair();
                        return true;
                    case "4":
                    Environment.Exit(-1);
                        return false;
                    default:

                        return true;
                }

            }

            public static void goVehicles()
            {
                Console.Clear();
               Vehicle.Vehiclemenu();
          
                Console.ReadKey();

            }

            public static void goInventory()
            {
                Console.Clear();
            Inventory.Inventorymenu();
                Console.ReadKey();

            }

            public static void goRepair()
            {
                Console.Clear();
                 Repair.Repairmenu();
            Console.ReadKey();

            }
        }
    }
