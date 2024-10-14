
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project2
{
    internal class Program
    {
        static List<Members> registeredMembers = new List<Members>();
        static List<Orders> placedOrders = new List<Orders>();
        static void Main(string[] angs)
        {
            Menu menu = new Menu();
            while (true)
            {
                menu.DisplayMenu();
                Menu.Option choice = menu.GetUserChoice();
                switch (choice)
                {
                    case Menu.Option.Register:
                        RegisterMember();
                        break;
                    case Menu.Option.ViewRegisteredMembers:
                        ViewRegisteredMembers();
                        break;
                    case Menu.Option.PlaceOrder:
                        PlaceOrder();
                        break;
                    case Menu.Option.ViewPlacedOrders:
                        ViewPlacedOrders();
                        break;
                    case Menu.Option.Exit:
                        Console.WriteLine("Exiting - See you later");
                        return;
                }
            }
        }

        static void RegisterMember()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Are you a student? (yes/no): ");
            bool isStudent = Console.ReadLine().Trim().ToLower() == "yes";
            registeredMembers.Add(new Members(name, isStudent));
            Console.WriteLine("You have been registered successfully!");
        }

        static void ViewRegisteredMembers()
        {
            Console.WriteLine("Registered Members:");
            foreach (var member in registeredMembers)
            {
                Console.WriteLine($"{member.Name} - {(member.IsStudent ? "Student" : "Lecturer")}");
            }
        }

        static void PlaceOrder()
        {
            ViewRegisteredMembers();
            Console.Write("Enter your name in order to place an order: ");
            string name = Console.ReadLine();
            Members customer = registeredMembers.Find(m => m.Name == name);
            if (customer == null)
            {
                Console.WriteLine("Member not found.");
                return;
            }
            placedOrders.Add(new Orders(customer));
            Console.WriteLine("Order placed successfully!");
        }

        static void ViewPlacedOrders()
        {
            Console.WriteLine("Placed Orders:");
            foreach (var order in placedOrders)
            {
                Console.WriteLine($"{order.Customer.Name} - {order.OrderDate}");
            }
        }
    }
}


