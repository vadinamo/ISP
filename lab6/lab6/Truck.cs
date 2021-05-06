using System;
using System.Collections.Generic;

namespace lab6
{
    public class Truck : Vehicle
    {
        private uint _liftingCapacity;
        private string _trailer;
        
        public uint LiftingCapacity
        {
            get
            {
                return _liftingCapacity;
            }

            set
            {
                _liftingCapacity = value;
            }
        }
        
        public string Trailer
        {
            get
            {
                return _trailer;
            }

            set
            {
                _trailer = value;
            }
        }

        public Truck()
        {
            LiftingCapacity = 0;
            Trailer = "";
        }
        
        public Truck(string brand, string model, float engineVolume,
            uint yearOfIssue, uint mileage, uint topSpeed, uint price,
            uint liftingCapacity, string trailer) : base(brand, model, engineVolume,
            yearOfIssue, mileage,
            topSpeed, price)
        {
            LiftingCapacity = liftingCapacity;
            Trailer = trailer;
        }

        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Lifting capacity: {LiftingCapacity}\nTrailer: {Trailer}\n");
        }

        public void Information(List<Truck> truck)
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