using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Assignment1
{
    class Inventory
    {

        public static List<Inventory> inventoryitems = new List<Inventory>()
            {
            new Inventory { inventoryId=1001,vehicleId = 1,numberOnHand=7,price=210,cost=150 },
            new Inventory { inventoryId=1002,vehicleId = 2,numberOnHand=8,price=240,cost=150 },
            new Inventory { inventoryId=1003,vehicleId = 3,numberOnHand=1,price=300,cost=290 },
            new Inventory { inventoryId=1004,vehicleId = 4,numberOnHand=3,price=460,cost=370 },
            new Inventory { inventoryId=1005,vehicleId = 5,numberOnHand=5,price=310,cost=210 }
            };

        public int inventoryId{
            get; set;
        }
        public int vehicleId { 
            get; set;
        }
        public int numberOnHand { 
            get; set;
        }
        public int price {
            get; set; 
        }
        public int cost {
            get; set;
        }

        public static void Inventorymenu()
        {
            Console.WriteLine("Press 1 to list all Inventory");
            Console.WriteLine("Press 2 to add a new Inventory");
            Console.WriteLine("Press 3 to update a Inventory");
            Console.WriteLine("Press 4 to delete a Inventory");
            Console.WriteLine("Press 5 to return to main menu");
            switch (Console.ReadLine())
            {
                case "1":

                    inventoryItem();
                    break;

                case "2":

                    inventoryAdd();
                    break;

                case "3":

                    inventoryUpdate();
                    break;

                case "4":

                    inventoryDelete();
                    break;

                case "5":
                    Program.MainMenu();
                    break;

                default:
                    Console.WriteLine("Please enter valid Input");
                    break;
            }
            Console.ReadKey();
        }
        public static void inventoryItem()
        {

            Console.WriteLine("Inventory Item");
            var show = from inv in inventoryitems
                       select new { inventoryId = inv.inventoryId, vehicleId = inv.vehicleId, numberOnhand = inv.numberOnHand, price = inv.price, cost = inv.cost };

            foreach (var sh in show)
                Console.WriteLine(sh);

            Console.ReadKey();

        }

        public static List<Inventory> inventoryAdd()
        {
            try
            {
                Console.WriteLine("Insert the Inventory Information");
                Console.WriteLine("Enter the Inventory Id");
                string inventoryId = Console.ReadLine();
                Console.WriteLine("Enter the vehicle Id");
                string vehicleId = Console.ReadLine();
                Console.WriteLine("Enter number on hand");
                string numHand = Console.ReadLine();
                Console.WriteLine("Enter price");
                string price = Console.ReadLine();
                Console.WriteLine("Enter cost");
                string cost = Console.ReadLine();

                inventoryitems.Add(new Inventory()
                {
                    inventoryId = int.Parse(inventoryId),
                    vehicleId = int.Parse(vehicleId),
                    numberOnHand = int.Parse(numHand),
                    price = int.Parse(price),
                    cost = int.Parse(cost),
                }
                );


                Console.WriteLine("Insert Completed");
                inventoryItem();

                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");

            }
            finally
            {
                Console.WriteLine("Thank you for visiting ");
            }
            return inventoryitems;
        }

        public static List<Inventory> inventoryUpdate()
        {
            try
            {

                Console.WriteLine("Update Vehicle Information");
                inventoryItem();


                Console.WriteLine("Please enter the Inventory Id that you want to update");
                int inventoryId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new Inventory Id");
                int newInventoryId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new vehicle Id");
                int newvehicleId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number on hand");
                int newnumHand = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new price");
                int newPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter new cost");
                int newCost = int.Parse(Console.ReadLine());


                var update = from up in inventoryitems
                             where up.inventoryId == inventoryId
                             select new { inventoryId = up.inventoryId = newInventoryId, vehicleId = up.vehicleId = newvehicleId, numberOnHand = up.numberOnHand = newnumHand, price = up.price = newPrice, cost = up.cost = newCost };
                foreach (var v in update)
                    Console.WriteLine(v);
                Console.WriteLine("List Updated");

                inventoryItem();
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
            return inventoryitems;
        }
        public static List<Inventory> inventoryDelete()
        {
            try
            {
                inventoryItem();

                Console.WriteLine("Delete the information using Inventory ID");
                Console.WriteLine("Please enter Inventory Id");
                int inventoryId = int.Parse(Console.ReadLine());


                var delete = from del in inventoryitems
                             where del.inventoryId != inventoryId
                             select new { del.inventoryId, del.vehicleId, del.numberOnHand, del.price, del.cost };
                foreach (var i in delete)
                    Console.WriteLine(i);
                Console.ReadKey();
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");

            }
            finally
            {
                Console.WriteLine("Thank you for visiting ");
            }

            return inventoryitems;
        }
    }
}

