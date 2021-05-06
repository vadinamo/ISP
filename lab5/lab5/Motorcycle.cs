using System;
using System.Collections.Generic;

namespace lab5
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            WheelCount = 0;
            SideCar = "";
        }

        public Motorcycle(string brand, string model, float engineVolume,
                   uint yearOfIssue, uint mileage, uint topSpeed, uint price, uint type,
                  uint wheelCount, string sideCar) : base(brand, model, engineVolume,
                                                        yearOfIssue, mileage,
                                                        topSpeed, price, type)
        {
            WheelCount = wheelCount;
            SideCar = sideCar;
        }

        public override void Information()
        {
            Console.WriteLine("Motorcycle.");
            base.Information();
            Console.WriteLine($"Wheel count: {WheelCount}\nSidecar: {SideCar}\n");
        }

        public void Information(List<Vehicle> motorcycle)
        {
            Console.WriteLine("Motorcycles:");
            if (motorcycle.Count > 0)
            {
                for (int i = 0; i < motorcycle.Count; i++) //вывод марки и модели введенных автомобилей
                {
                    motorcycle[i].Information(i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     No motorcycles entered.");
            }
        }
    }
}
