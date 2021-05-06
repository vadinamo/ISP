using System;
using System.Collections.Generic;

namespace lab6
{
    class Program
    {
        static void Main()
        {
            List<Car> car = new List<Car>();
            List<Truck> truck = new List<Truck>();
            List<Motorcycle> motorcycle = new List<Motorcycle>();
            int pick = -1;
            UserInterface userInterface = new UserInterface();
            
            while (pick != 0)
            {
                Console.WriteLine("1. View all vehicles.\n2. Add vehicle.\n3. Edit vehicle.\n" +
                                  "4. Delete vehicle.\n5. Vehicle information.\n0. Exit.");

                pick = userInterface.IntCheck();

                switch (pick)
                {
                    case 1:
                        userInterface.ViewAllVehicles(car, truck, motorcycle);

                        break;

                    case 2:
                        userInterface.AddVehicle(car, truck, motorcycle);

                        break;

                    case 3:
                        userInterface.EditVehicle(car, truck, motorcycle);

                        break;

                    case 4:
                        userInterface.DeleteVehicle(car, truck, motorcycle);

                        break;

                    case 5:
                        userInterface.VehicleInformation(car, truck, motorcycle);

                        break;
                }
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}