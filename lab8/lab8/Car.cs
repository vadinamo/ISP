using System;
using System.Collections.Generic;

namespace lab8
{
    class Car : Vehicle
    {
        private string _carType;
        private uint _doorCount;
        
        public string CarType
                {
                    get
                    {
                        return _carType;
                    }
        
                    set
                    {
                        _carType = value;
                    }
                }
                
                public uint DoorCount
                {
                    get
                    {
                        return _doorCount;
                    }
        
                    set
                    {
                        _doorCount = value;
                    }
                }
        public Car()
        {
            CarType = "";
            DoorCount = 0;
        }
        public Car(string brand, string model, double engineVolume,
            uint yearOfIssue, uint mileage, uint topSpeed, uint price, String type,
            string carType, uint doorCount) : base(brand, model, engineVolume,
            yearOfIssue, mileage,
            topSpeed, price, type)
        {
            CarType = carType;
            DoorCount = doorCount;
        }

        public override void Information()
        {
            Console.WriteLine("Car.");
            base.Information();
            Console.WriteLine($"Car type: {CarType}\nDoor count: {DoorCount}\n");
        }

        public void Information(List<Vehicle> car)
        {
            Console.WriteLine("Cars:");
            if (car.Count > 0)
            {
                for (int i = 0; i < car.Count; i++) //вывод марки и модели введенных автомобилей
                {
                    if(car[i].Type == "Car") car[i].Information(i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     No cars entered.");
            }
        }
    }
}