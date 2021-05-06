using System;
using System.Collections.Generic;

namespace lab5
{
    class Truck : Vehicle
    {
        public Truck()
        {
            LiftingCapacity = 0;
            Trailer = "";
        }
        
        public Truck(string brand, string model, float engineVolume,
                   uint yearOfIssue, uint mileage, uint topSpeed, uint price, uint type,
                  uint liftingCapacity, string trailer) : base(brand, model, engineVolume,
                                                        yearOfIssue, mileage,
                                                        topSpeed, price, type)
        {
            LiftingCapacity = liftingCapacity;
            Trailer = trailer;
        }

        public override void Information()
        {
            Console.WriteLine("Truck.");
            base.Information();
            Console.WriteLine($"Lifting capacity: {LiftingCapacity}\nTrailer: {Trailer}\n");
        }

        public void Information(List<Vehicle> truck)
        {
            Console.WriteLine("Trucks:");
            if (truck.Count > 0)
            {
                for (int i = 0; i < truck.Count; i++) //вывод марки и модели введенных автомобилей
                {
                    truck[i].Information(i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     No trucks entered.");
            }
        }
    }
}
