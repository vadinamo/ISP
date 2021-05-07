using System;
using System.Collections.Generic;

namespace lab6
{
    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicle = new List<Vehicle>();
            UserInterface userInterface = new UserInterface();
            int pick = -1;
            
            userInterface.Test(vehicle);
            
            while (pick != 0)
            {
                Console.WriteLine("1. View all vehicles.\n2. Add vehicle.\n3. Edit vehicle.\n" +
                                  "4. Delete vehicle.\n5. Vehicle information.\n6. Sort by price.\n0. Exit.");
                pick = userInterface.IntCheck();

                switch (pick)
                {
                    case 1:
                        userInterface.ViewAllVehicles(vehicle);
                        break;

                    case 2:
                        userInterface.AddVehicle(vehicle);
                        break;

                    case 3:
                        userInterface.EditVehicle(vehicle);
                        break;

                    case 4:
                        userInterface.DeleteVehicle(vehicle);
                        break;

                    case 5:
                        userInterface.VehicleInformation(vehicle);
                        break;
                    
                    case 6:
                        userInterface.SortByPrice(vehicle);
                        break;
                }
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}