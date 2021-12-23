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

    class Vehicle
    {
      

        public static List<Vehicle> vehiclelist = new List<Vehicle>()
            {
               new Vehicle(){vehicleID=1,make="Cheverlot",model="basic",year="2015",newcar="no"},
               new Vehicle(){vehicleID=2,make="Audi",model="premium",year= "2020",newcar="yes"},
               new Vehicle(){vehicleID=3,make="BMW",model="basic",year= "2016",newcar="no"},
               new Vehicle(){vehicleID=4,make="Honda",model="ultrapremium",year= "2017",newcar="no"},
               new Vehicle(){vehicleID=5,make="Mercedes",model="premium",year= "2018",newcar="yes"}
            };
        public int vehicleID { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string newcar { get; set; }

     

        public static void Vehiclemenu()
        {
          
            
            Console.WriteLine("Press 1 to list all vehicles");
            Console.WriteLine("Press 2 to add new vehicles");
            Console.WriteLine("Press 3 to update vehicles");
            Console.WriteLine("Press 4 to delete vehicles");
            Console.WriteLine("Press 5 to return to main menu");

            switch (Console.ReadLine())
            {
                case "1" :
                    VehicleList();
                    break;
                case "2":
                    VehicleAdd();
                    break;
                case "3":
                    VehicleUpdate();
                    break;
                case "4":
                    VehicleDelete();
                    break;
                case "5":
                    Program.MainMenu();
                    break;
                default:
                    Console.WriteLine("Please enter valid number for menu");
                    break;


            }
            Console.ReadKey();
            Console.Clear();
        }

     
        public static List<Vehicle> VehicleList() 
        {
            Console.Clear();
            var item = from vehicleitem in vehiclelist
                       select new {vehicleitem.vehicleID,vehicleitem.make,vehicleitem.model,vehicleitem.year,vehicleitem.newcar };
           
            foreach (var it in item)
                Console.WriteLine(it);
            Console.WriteLine("Press any key to return to previous menu");
            Console.ReadKey();
            Console.Clear();
            Vehiclemenu();
            return vehiclelist;
        

          }
        public static List<Vehicle> VehicleAdd()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Insert Vehicle Information");
                Console.WriteLine("Enter vehicle Id");
                string vehicleID = Console.ReadLine();
                Console.WriteLine("Enter vehicle make");
                string vehicleMake = Console.ReadLine();

                while (true)
                {
                    if (String.IsNullOrEmpty(vehicleMake))
                    {
                        Console.WriteLine("Invalid input");
                        VehicleAdd();
                    }
                    else
                    {
                        break;
                    }
                }
                
                Console.WriteLine("Enter vehicle model");
                string vehicleModel = Console.ReadLine();
                while (true)
                {
                    if (String.IsNullOrEmpty(vehicleModel))
                    {
                        Console.WriteLine("Invalid input");
                        VehicleAdd();
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Enter vehicle year");
                string vehicleYear = Console.ReadLine();
                while (true)
                {
                    if (String.IsNullOrEmpty(vehicleYear))
                    {
                        Console.WriteLine("Invalid input");
                        VehicleAdd();
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Enter vehicle usedcar[yes/no]");
                string vehicleUsedCar = Console.ReadLine();
                while (true)
                {
                    if (String.IsNullOrEmpty(vehicleUsedCar))
                    {
                        Console.WriteLine("Invalid input");
                        VehicleAdd();
                    }
                    else
                    {
                        break;
                    }
                }

                vehiclelist.Add(new Vehicle()
                {
                    vehicleID = int.Parse(vehicleID),
                    make = vehicleMake,
                    model = vehicleModel,
                    year = vehicleYear,
                    newcar = vehicleUsedCar
                });


                Console.WriteLine("New car information added in the list:");
                var list = from vehitem in vehiclelist
                           select new { vehitem.vehicleID, vehitem.make, vehitem.model, vehitem.year, vehitem.newcar };

                foreach (var i in list)
                    Console.WriteLine(i);
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey();
                Console.Clear();
                Vehiclemenu();
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
            return vehiclelist;


        }
        public static List<Vehicle> VehicleUpdate()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Update Vehicle Information");
                var list = from vehitem in vehiclelist
                           select new { item = vehitem.vehicleID, vehitem.make, vehitem.model, vehitem.year, vehitem.newcar };

                foreach (var i in list)
                    Console.WriteLine(i);


                Console.WriteLine("Enter vehicle Id that you want to update");
                int vehid = int.Parse(Console.ReadLine());



                Console.WriteLine("Enter new vehicle make");
                string newmake = Console.ReadLine();
                Console.WriteLine("Enter vehicle model");
                string newmodel = Console.ReadLine();
                Console.WriteLine("Enter new vehicle year");
                string newyear = Console.ReadLine();
                Console.WriteLine("Enter new vehicle usedcar[yes/no]");
                string newusedcar = Console.ReadLine();



                var update = from u in vehiclelist

                             where u.vehicleID == vehid
                             select new { vid = u.vehicleID = vehid, make = u.make = newmake, model = u.model = newmodel, year = u.year = newyear, newcar = u.newcar = newusedcar };

                Console.WriteLine("New List updated now");

                foreach (var it in update)
                    Console.WriteLine(it);
                VehicleList();
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error:  { exception.Message }");
            }
            finally
            {
                Console.WriteLine("Thank your  for visiting");
            }
            return vehiclelist;
        }
        public static List<Vehicle> VehicleDelete()
        {
            try
            {
                Console.Clear();
                var list = from vehitem in vehiclelist
                           select new { vehitem.vehicleID, vehitem.make, vehitem.model, vehitem.year, vehitem.newcar };

                foreach (var i in list)
                    Console.WriteLine(i);


                Console.WriteLine("Delete the  Vehicle Information that you want using Vehicle ID");
                Console.WriteLine("Enter vehicle Id");
                int vehid = int.Parse(Console.ReadLine());

                Console.WriteLine("After deleting updated information ");
                var remove = from r in vehiclelist
                             where r.vehicleID != vehid
                             select new { r.vehicleID, r.make, r.model, r.year, r.newcar };
                foreach (var i in remove)
                    Console.WriteLine(i);
                Console.WriteLine("Press any key to return to previous menu");
                Console.ReadKey();
                Console.Clear();
                Vehiclemenu();
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
            return vehiclelist;
        }

    }
}
