using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship cargo = new CargoShip(10);
            Ship tanker = new Tanker(6);
            Ship boat = new MotorBoat(17);

            string cont = default;
            while (cont != "end")
            {

                Console.WriteLine("Choose the option:\n1.Show ships' stats\n2.Get fuel type\n3.Refuel ship\n");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        cargo.ShowStats();
                        tanker.ShowStats();
                        boat.ShowStats();
                        break;

                    case 2:
                        Console.WriteLine("Which ships' fuel type would you like to see?");
                        string cl = Console.ReadLine().ToLower();
                        switch (cl)
                        {
                            case "cargoship":
                                Console.WriteLine(cargo.GetFuelType());
                                break;
                            case "tanker":
                                Console.WriteLine(tanker.GetFuelType());
                                break;
                            case "motorboat":
                                Console.WriteLine(boat.GetFuelType());
                                break;
                            default:
                                Console.WriteLine("returning to menu...");
                                break;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Which ships' fuel type would you like to refuel?");
                        string choice = Console.ReadLine().ToLower();
                        switch (choice)
                        {
                            case "cargoship":
                                cargo.Refueling();
                                break;
                            case "tanker":
                                tanker.Refueling();
                                break;
                            case "motorboat":
                                boat.Refueling();
                                break;
                            default:
                                Console.WriteLine("returning to menu...");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Returning to menu...");
                        break;

                }
                Console.WriteLine("\nType \"end\" for closing program");
                cont = Console.ReadLine();
            }
        }
    }
}
