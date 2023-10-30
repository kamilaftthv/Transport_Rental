using System;
using System.Collections.Generic;
using Transport_Rental.Classes;

namespace TransportRental
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transport> lst = new List<Transport>();

            lst.Add(new Boat("Boat5356", "Blue", 50, "Category 1"));
            lst.Add(new Car("CarSuper564", "Red", 200, "Category B"));
            lst.Add(new Bicycle("Bicycle123", "Green", 20, "-"));
            lst.Add(new Motorcycle("MotorcycleBest111", "Yellow", 250, "Category A"));
            lst.Add(new Scooter("ScooterFast01", "Black", 45, "-"));

            lst.Sort((x, y) => string.Compare(x.Model, y.Model, StringComparison.OrdinalIgnoreCase));

            while (true)
            {
                Console.WriteLine("Available types of transport:");
                foreach (var transport in lst)
                {
                    Console.WriteLine(transport.GetType().Name);
                }

                Console.Write("Select transport type (or 'exit' to complete): ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    break;
                }

                Transport selectedTransport = lst.Find(t => t.GetType().Name.ToLower() == userInput.ToLower());

                if (selectedTransport != null)
                {
                    Console.WriteLine($"Transport '{selectedTransport.GetType().Name}':");
                    selectedTransport.PrintInfo();
                    string isRentedString = selectedTransport.IsRented ? "yes" : "no";
                    Console.WriteLine($"Rented: {isRentedString}");
                }
                else
                {
                    Console.WriteLine("This type of transport was not found.");
                }
            }
        }
    }
}











