using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Menu
    {
        internal enum Option
        {
            Register = 1,
            ViewRegisteredMembers,
            PlaceOrder,
            ViewPlacedOrders,
            Exit
        }

        internal void DisplayMenu()
        {
            Console.WriteLine("Welcome to BC-Eats!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. View registered members");
            Console.WriteLine("3. Place an order");
            Console.WriteLine("4. View placed orders");
            Console.WriteLine("5. Exit");
        }

        internal Option GetUserChoice()
        {
            int choice;
            while (true)
            {
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out choice) && Enum.IsDefined(typeof(Option), choice))
                {
                    return (Option)choice;
                }
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}

