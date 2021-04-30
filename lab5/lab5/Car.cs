using System;
using System.Collections.Generic;

namespace lab5
{
    class Car : Vehicle
    {
        public string CarType;
        public uint DoorCount;

        public Car() : base()
        {
            CarType = "";
            DoorCount = 0;
        }
        public Car(string brand, string model, float engineVolume,
                   uint yearOfIssue, uint mileage, uint topSpeed, uint price,
                   string carType, uint doorCount) : base(brand, model, engineVolume,
                                                         yearOfIssue, mileage,
                                                         topSpeed, price)
        {
            CarType = carType;
            DoorCount = doorCount;
        }

        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Car type: {CarType}\nDoor count: {DoorCount}\n");
        }

        public void Information(List<Car> car)
        {
            Console.WriteLine("Cars:");
            if (car.Count > 0)
            {
                for (int i = 0; i < car.Count; i++) //вывод марки и модели введенных автомобилей
                {
                    car[i].Information(i);
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
