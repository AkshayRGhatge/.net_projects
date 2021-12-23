using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.IO;
using System.Threading;


namespace Assignment1
{
    class Repair
    {

        public static List<Repair> RepairItem = new List<Repair>()
            {
            new Repair { repairId=1, inventoryId=1001, whatToRepair="Tire"},
            new Repair { repairId=2, inventoryId=1002, whatToRepair="Brake"},
            new Repair { repairId=3, inventoryId=1003, whatToRepair="Oil change"},
            new Repair { repairId=4, inventoryId=1004, whatToRepair="Ignition System"},
            new Repair { repairId=5, inventoryId=1005, whatToRepair="Oxygen Sensor Replacement"},
            new Repair { repairId=6, inventoryId=1006, whatToRepair="Spark plug replacement "},
            new Repair { repairId=7, inventoryId=1007, whatToRepair="Electrical system"},
        };



        public int repairId{
            get; set;
        }
        public int inventoryId {
            get; set; 
        }
        public string whatToRepair { 
            get; set;
        }
        public static void Repairmenu()
        {
            Console.WriteLine("Press 1 to list all repairs");
            Console.WriteLine("Press 2 to add a new repair information");
            Console.WriteLine("Press 3 to update repair information");
            Console.WriteLine("Press 4 to delete information");
            Console.WriteLine("Press 5 to return to main menu");
            switch (Console.ReadLine())
            {
             
                case "1":
                    RepairList();
                    break;
                case "2":
                    RepairAdd();
                    break;
                case "3":
                    RepairUpdate();
                    break;
                case "4":
                    RepairDelete();
                    break;
                case "5":
                    Program.MainMenu();
                    break;
                default:
                    Console.WriteLine("Please enter the valid number");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static List<Repair> RepairList()
        {
            Console.Clear();
            Console.WriteLine("List of Repairs");
            var list = from ri in RepairItem
                          select new { repairId = ri.repairId, inventoryId = ri.inventoryId, whatToRepair = ri.whatToRepair };

            foreach (var rep in list)
                Console.WriteLine(rep);
            Console.WriteLine("Press any key to return to previous menu");
            Console.ReadKey();
            Console.Clear();
            Repairmenu();
            return RepairItem;
        }

        public static List<Repair> RepairAdd()
        {
            try
            {
                Console.Clear();
                string whatToRepair;
                Console.WriteLine("Insert new Repair Information");
                Console.WriteLine("Enter Repair Id");
                string repairId = Console.ReadLine();
                Console.WriteLine("Enter Inventory Id");
                string inventoryId = Console.ReadLine();
                Console.WriteLine("Enter What to repair");

                whatToRepair = Console.ReadLine();
                while (true)
                {
                    if (String.IsNullOrEmpty(whatToRepair))
                    {
                        Console.WriteLine("Please enter a valid input");
                        RepairAdd();
                    }
                    else
                    {
                        break;
                    }
                }

                    RepairItem.Add(new Repair()
                    {
                        repairId = int.Parse(repairId),
                        inventoryId = int.Parse(inventoryId),
                        whatToRepair = whatToRepair
                    }); 


                    Console.WriteLine("Insert Completed");
                    RepairList();
                   
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey();
                Console.Clear();
                Repairmenu();

            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");

            }
            finally
            {
                Console.WriteLine("Thank you for visiting");
            }
        
            return RepairItem;
        }
        public static List<Repair> RepairUpdate()
        {
            try
            {
                Console.Clear();
                var list = from ri in RepairItem
                           select new { repairId = ri.repairId, inventoryId = ri.inventoryId, whatToRepair = ri.whatToRepair };

                foreach (var rep in list)
                    Console.WriteLine(rep);
                string newRepair;
                Console.WriteLine("Enter repairId that you want to update");
                int repairId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new repair Id");
                int newRepairId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new inventory Id");
                int newInventoryId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter What to repair");
                do
                {
                    newRepair = Console.ReadLine();
                    if (String.IsNullOrEmpty(newRepair))
                    {
                        Console.WriteLine("Please enter valid input");
                        Console.WriteLine("Enter what to repair information ");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                var update = from r in RepairItem
                             where r.repairId == repairId
                             select new { repairId = r.repairId = newRepairId, inventoryId = r.inventoryId = newInventoryId, whatToRepair = r.whatToRepair = newRepair};
                foreach (var r in update)
                    Console.WriteLine(r);
                Console.WriteLine("List Updated");

                RepairList();
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");

            }
            finally
            {
                Console.WriteLine("Thank you for visiting");
            }
            return RepairItem;
        }
        public static List<Repair> RepairDelete()
        {
            try
            {
                Console.Clear();
                var list = from ri in RepairItem
                           select new { repairId = ri.repairId, inventoryId = ri.inventoryId, whatToRepair = ri.whatToRepair };

                foreach (var rep in list)
                    Console.WriteLine(rep);


                Console.WriteLine("Enter the repair Id that you want to delete");
                int repairId = int.Parse(Console.ReadLine());



                var delete = from d in RepairItem
                             where d.repairId != repairId
                             select new { d.repairId, d.inventoryId, d.whatToRepair };
                foreach (var del in delete)
                    Console.WriteLine(del);
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey();
                Console.Clear();
                Repairmenu();
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");

            }
            finally
            {
                Console.WriteLine("Thank you for visiting");
            }
            return RepairItem;
        }
    }
}

