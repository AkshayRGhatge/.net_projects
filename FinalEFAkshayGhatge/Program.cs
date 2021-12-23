using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEFAkshayGhatge
{
    class Program
    {

        static void Main(string[] args)
        {
            bool menu = true;
            while (menu)
            {
                menu = Menu();
            }
        }
        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - View all Authors");
            Console.WriteLine("2 - Add Author ");
            Console.WriteLine("3 - Update Author");
            Console.WriteLine("4 - Exit");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Program.viewAuthor();
                    return true;
                case "2":
                    Console.Clear();
                    Program.addAuthor();
                    return true;
                case "3":
                    Console.Clear();
                    Program.updateAuthor();
                    return true;
                case "4":
                    Environment.Exit(-1);
                    return false;
                default:

                    return true;
            }
        }
        

        static void updateAuthor()
        {
            using (var context = new BooksDBEntities())
            {
                int autID;
             
                string fname, lname, phone, address, city, state;
                Console.WriteLine("Enter author id that you need to update");
                autID = Int32.Parse(Console.ReadLine());
                var book = context.Authors.Find(autID);
                Console.WriteLine("Update First Name");
                do
                {
                    fname = Console.ReadLine();
                    if (string.IsNullOrEmpty(fname))

                    {
                        Console.WriteLine("Please enter fname");
                        Console.WriteLine("Enter First Name");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

               
                Console.WriteLine("Update Last Name");
                do
                {
                    lname = Console.ReadLine();
                    if (string.IsNullOrEmpty(lname))

                    {
                        Console.WriteLine("Please enter lname");
                        Console.WriteLine("Enter last Name");
                    }
                    else
                    {
                        break;
                    }
                } while (true);
              
                Console.WriteLine("Update phone");
                do
                {
                    phone = Console.ReadLine();
                    if (string.IsNullOrEmpty(phone))

                    {
                        Console.WriteLine("Please enter phone");
                        Console.WriteLine("Enter phone number");
                    }
                    else
                    {
                        break;
                    }
                } while (true);
             
                Console.WriteLine("Update address");
                do
                {
                    address = Console.ReadLine();
                    if (string.IsNullOrEmpty(address))

                    {
                        Console.WriteLine("Please enter address");
                        Console.WriteLine("Enter address");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

              
                Console.WriteLine("Update city");
                do
                {
                    city = Console.ReadLine();
                    if (string.IsNullOrEmpty(city))

                    {
                        Console.WriteLine("Please enter city");
                        Console.WriteLine("Enter city");
                    }
                    else
                    {
                        break;
                    }
                } while (true);
              
                Console.WriteLine("Update state");
                do
                {
                    state = Console.ReadLine();
                    if (string.IsNullOrEmpty(state))

                    {
                        Console.WriteLine("Please enter state");
                        Console.WriteLine("Enter state");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

            
               
                book.FirstName = fname;
                book.LastName = lname;
                book.Phone = phone;
                book.Address = address;
                book.City = city;
                book.State = state;
                
                context.SaveChanges();
                Console.WriteLine("Updated Successfully");
                Console.WriteLine("");
                Console.WriteLine("Press any key to go back to main menu");
                Console.ReadKey();

            }
        }


        static void addAuthor()
        {

            using (var context = new BooksDBEntities())
            {
                string fname, lname, phone, address, city, state;
                Console.WriteLine("Enter First Name");
                do
                {
                    fname = Console.ReadLine();
                    if (string.IsNullOrEmpty(fname))

                    {
                        Console.WriteLine("Please enter fname");
                        Console.WriteLine("Enter First Name");
                    }
                    else {
                        break;
                    }
                } while (true);

                Console.WriteLine("Enter Last Name");
                do
                {
                    lname = Console.ReadLine();
                    if (string.IsNullOrEmpty(lname))

                    {
                        Console.WriteLine("Please enter lname");
                        Console.WriteLine("Enter last Name");
                    }
                    else
                    {
                        break;
                    }
                } while (true);


                Console.WriteLine("Enter phone");
                do
                {
                    phone = Console.ReadLine();
                    if (string.IsNullOrEmpty(phone))

                    {
                        Console.WriteLine("Please enter phone");
                        Console.WriteLine("Enter phone number");
                    }
                    else
                    {
                        break;
                    }
                } while (true);
         
                Console.WriteLine("Enter address");
                do
                {
                    address = Console.ReadLine();
                    if (string.IsNullOrEmpty(address))

                    {
                        Console.WriteLine("Please enter address");
                        Console.WriteLine("Enter address");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

         
                Console.WriteLine("Enter city");
                do
                {
                    city = Console.ReadLine();
                    if (string.IsNullOrEmpty(city))

                    {
                        Console.WriteLine("Please enter city");
                        Console.WriteLine("Enter city");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                Console.WriteLine("Enter state");
                do
                {
                    state = Console.ReadLine();
                    if (string.IsNullOrEmpty(state))

                    {
                        Console.WriteLine("Please enter state");
                        Console.WriteLine("Enter state");
                    }
                    else
                    {
                        break;
                    }
                } while (true);
               
                    var book = new Author();
                    book.FirstName = fname;
                    book.LastName = lname;
                    book.Phone = phone;
                    book.Address = address;
                    book.City = city;
                    book.State = state;
                    context.Authors.Add(book);
                    context.SaveChanges();
                    Console.WriteLine("Added Author Successfully");
                    Console.WriteLine("");
                
                Console.WriteLine("Press any key to go back to main menu");
                Console.ReadKey();

            }
        }
        static void viewAuthor()
        {
            using (var context = new BooksDBEntities())
           {
                var query = (from a in context.Authors
                             select a);
                Console.WriteLine($"{"Author ID",6} {"First Name",-20} {"Last Name",-20} {"Phone",-15}  {"Address ",-25} {"City",-17} {"State ",1}");
                Console.WriteLine("======================================================================================================================");
              
              foreach (var author in query)
              {
                  Console.WriteLine($"{author.AuthorID,-10}|{author.FirstName,-20}|{author.LastName,-20 }|{author.Phone,-15}|{author.Address,-25}|{author.City,-15 }|{author.State,3}");
              }
                Console.WriteLine("Press any key to go back to main menu");
              Console.ReadKey();
         }  
        } 
    }
}
