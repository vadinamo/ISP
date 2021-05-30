using System;
using System.Collections.Generic;

namespace lab8
{
    class Motorcycle : Vehicle
    {
        private uint _wheelCount;
        private string _sideCar;
        
        public uint WheelCount
        { 
            get
            {
                return _wheelCount;
            }
            
            set 
            {
                _wheelCount = value;
            }
        }
                
        public string SideCar 
        {
            get
            {
                return _sideCar;
            }
        
            set
            {
                _sideCar = value;
            }
        }
                
        public Motorcycle()
        {
            WheelCount = 0;
            SideCar = "";
        }

        public Motorcycle(string brand, string model, double engineVolume,
            uint yearOfIssue, uint mileage, uint topSpeed, uint price, string type,
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
                    if(motorcycle[i].Type == "Motorcycle") motorcycle[i].Information(i);
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