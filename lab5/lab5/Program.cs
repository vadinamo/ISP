using System;
using System.Collections.Generic;

namespace lab5
{
    class Program
    {
        struct Charast
        {
            public string brand, model, carType, trailer, sideCar;
            public float engineVolume;
            public uint yearOfIssue, mileage, topSpeed, doorCount, price, liftingCapacity, wheelCount;
        }

        static Charast vehicle;

        static uint UintCheck() //проверка ввода uint
        {
            uint a;
            while (!uint.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Ошибка!");
            }
            return a;
        }

        static int IntCheck()   //проверка ввода int
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Ошибка!");
            }
            return a;
        }

        static float FloatCheck()   ////проверка ввода float
        {
            float a;
            while (!float.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Ошибка!");
            }
            return a;
        }

        static void AddVehicle(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
        { 
            Console.WriteLine("1.Add car.\n2.Add truck.\n3.Add motorcycle.\n");
            uint operation = UintCheck();

            if (operation != 1 && operation != 2 && operation != 3) //проверка ввода
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.Write("Brand: ");
            vehicle.brand = Console.ReadLine();
            Console.Write("Model: ");
            vehicle.model = Console.ReadLine();
            Console.Write("Price(BYN): ");
            vehicle.price = UintCheck();
            Console.Write("Engine volume: ");
            vehicle.engineVolume = FloatCheck();
            Console.Write("Year of issue:");
            vehicle.yearOfIssue = UintCheck();
            Console.Write("Mileage:");
            vehicle.mileage = UintCheck();
            Console.Write("Top speed:");
            vehicle.topSpeed = UintCheck();

            switch(operation)
            {
                case 1:
                    Console.Write("Car type:");
                    vehicle.carType = Console.ReadLine();
                    Console.Write("Door count:");
                    vehicle.doorCount = UintCheck();

                    car.Add(new Car() //добавление объекта класса Car 
                    {
                        Brand = vehicle.brand,
                        Model = vehicle.model,
                        Price = vehicle.price,
                        EngineVolume = vehicle.engineVolume,
                        YearOfIssue = vehicle.yearOfIssue,
                        Mileage = vehicle.mileage,
                        TopSpeed = vehicle.topSpeed,
                        CarType = vehicle.carType,
                        DoorCount = vehicle.doorCount
                    });
                    break;

                case 2:
                    Console.Write("Trailer:");
                    vehicle.trailer = Console.ReadLine();
                    Console.Write("Lifting capacity:");
                    vehicle.liftingCapacity = UintCheck();

                    truck.Add(new Truck() //добавление объекта класса Car 
                    {
                        Brand = vehicle.brand,
                        Model = vehicle.model,
                        Price = vehicle.price,
                        EngineVolume = vehicle.engineVolume,
                        YearOfIssue = vehicle.yearOfIssue,
                        Mileage = vehicle.mileage,
                        TopSpeed = vehicle.topSpeed,
                        LiftingCapacity = vehicle.liftingCapacity,
                        Trailer = vehicle.trailer,
                    });
                    break;

                case 3:
                    Console.Write("Sidecar:");
                    vehicle.sideCar = Console.ReadLine();
                    Console.Write("Wheel count:");
                    vehicle.wheelCount = UintCheck();

                    motorcycle.Add(new Motorcycle() //добавление объекта класса Car 
                    {
                        Brand = vehicle.brand,
                        Model = vehicle.model,
                        Price = vehicle.price,
                        EngineVolume = vehicle.engineVolume,
                        YearOfIssue = vehicle.yearOfIssue,
                        Mileage = vehicle.mileage,
                        TopSpeed = vehicle.topSpeed,
                        SideCar = vehicle.sideCar,
                        WheelCount = vehicle.wheelCount,
                    });
                    break;
            }
        }

        static void EditVehicle(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
        { 
            Console.WriteLine("1.Edit car.\n2.Edit truck.\n3.Edit motorcycle.\n");

            uint operation = UintCheck();
            if (operation != 1 && operation != 2 && operation != 3) //проверка ввода
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.WriteLine("Enter vehicle number.");
            int number = IntCheck() - 1;

            switch(operation)
            {
                case 1:
                    if(number < 0 || number > car.Count)
                    {
                        Console.WriteLine("Incorrect number!");
                        return;
                    }

                    break;

                case 2:
                    if (number < 0 || number >= truck.Count)
                    {
                        Console.WriteLine("Incorrect number!");
                        return;
                    }

                    break;

                case 3:
                    if (number < 0 || number >= motorcycle.Count)
                    {
                        Console.WriteLine("Incorrect number!");
                        return;
                    }

                    break;
            }

            Console.Write("Brand: ");
            vehicle.brand = Console.ReadLine();
            Console.Write("Model: ");
            vehicle.model = Console.ReadLine();
            Console.Write("Price(BYN): ");
            vehicle.price = UintCheck();
            Console.Write("Engine volume: ");
            vehicle.engineVolume = FloatCheck();
            Console.Write("Year of issue:");
            vehicle.yearOfIssue = UintCheck();
            Console.Write("Mileage:");
            vehicle.mileage = UintCheck();
            Console.Write("Top speed:");
            vehicle.topSpeed = UintCheck();

            switch (operation)
            {
                case 1:
                    Console.Write("Car type:");
                    vehicle.carType = Console.ReadLine();
                    Console.Write("Door count:");
                    vehicle.doorCount = UintCheck();

                    car[number].Brand = vehicle.brand; //изменение полей объекта класса на введенные значения
                    car[number].Model = vehicle.model;
                    car[number].Price = vehicle.price;
                    car[number].EngineVolume = vehicle.engineVolume;
                    car[number].YearOfIssue = vehicle.yearOfIssue;
                    car[number].Mileage = vehicle.mileage;
                    car[number].TopSpeed = vehicle.topSpeed;
                    car[number].CarType = vehicle.carType;
                    car[number].DoorCount = vehicle.doorCount;

                    break;

                case 2:
                    Console.Write("Trailer:");
                    vehicle.trailer = Console.ReadLine();
                    Console.Write("Lifting capacity:");
                    vehicle.liftingCapacity = UintCheck();

                    truck[number].Brand = vehicle.brand; //изменение полей объекта класса на введенные значения
                    truck[number].Model = vehicle.model;
                    truck[number].Price = vehicle.price;
                    truck[number].EngineVolume = vehicle.engineVolume;
                    truck[number].YearOfIssue = vehicle.yearOfIssue;
                    truck[number].Mileage = vehicle.mileage;
                    truck[number].TopSpeed = vehicle.topSpeed;
                    truck[number].Trailer = vehicle.trailer;
                    truck[number].LiftingCapacity = vehicle.liftingCapacity;

                    break;

                case 3:
                    Console.Write("Sidecar:");
                    vehicle.sideCar = Console.ReadLine();
                    Console.Write("Wheel count:");
                    vehicle.wheelCount = UintCheck();

                    motorcycle[number].Brand = vehicle.brand; //изменение полей объекта класса на введенные значения
                    motorcycle[number].Model = vehicle.model;
                    motorcycle[number].Price = vehicle.price;
                    motorcycle[number].EngineVolume = vehicle.engineVolume;
                    motorcycle[number].YearOfIssue = vehicle.yearOfIssue;
                    motorcycle[number].Mileage = vehicle.mileage;
                    motorcycle[number].TopSpeed = vehicle.topSpeed;
                    motorcycle[number].SideCar = vehicle.sideCar;
                    motorcycle[number].WheelCount = vehicle.wheelCount;

                    break;
            }
        }

        static void DeleteVehicle(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
        {
            Console.WriteLine("1.Delete car.\n2.Delete truck.\n3.Delete motorcycle.\n");
            uint operation = UintCheck();

            Console.WriteLine("Enter vehicle number.");
            int number = IntCheck() - 1;

            switch (operation)
            {
                case 1:
                    if (number < 0 || number > car.Count)
                    {
                        Console.WriteLine("Incorrect number!");
                        return;
                    }

                    else
                    {
                        car.RemoveAt(number);
                        Console.WriteLine("Success");
                    }

                    break;

                case 2:
                    if (number < 0 || number >= truck.Count)
                    {
                        Console.WriteLine("Incorrect number!");
                        return;
                    }

                    else
                    {
                        truck.RemoveAt(number);
                        Console.WriteLine("Success");
                    }

                    break;

                case 3:
                    if (number < 0 || number >= motorcycle.Count)
                    {
                        Console.WriteLine("Incorrect number!");
                        return;
                    }

                    else
                    {
                        motorcycle.RemoveAt(number);
                        Console.WriteLine("Success");
                    }

                    break;
            }

        }

        static void VehicleInformation(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
        {
            Console.WriteLine("1.Car information.\n2.Truck information.\n3.Motorcycle information.\n");
            uint operation = UintCheck();
            switch (operation)
            {
                case 1:
                    car[0].Information(car);
                    break;

                case 2:
                    truck[0].Information(truck);
                    break;

                case 3:
                    motorcycle[0].Information(motorcycle);
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        static void ViewAllVehicles(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
        {
            Console.WriteLine("Cars:");
            if (car.Count != 0)
            {
                for (int i = 0; i < car.Count; i++) //вывод марки, модели и цены введенных автомобилей
                {
                    car[i].Information(i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     No cars entered.");
            }

            Console.WriteLine("Trucks:");
            if (truck.Count != 0)
            {
                for (int i = 0; i < truck.Count; i++) //вывод марки, модели и цены введенных грузовиков
                { 
                    truck[i].Information(i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     No trucks entered.");
            }

            Console.WriteLine("Motorcycles:");
            if (motorcycle.Count != 0)
            {
                for (int i = 0; i < motorcycle.Count; i++) //вывод марки, модели и цены введенных мотоциклов
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

        static void Main(string[] args)
        {
            List<Car> car = new List<Car>();
            List<Truck> truck = new List<Truck>();
            List<Motorcycle> motorcycle = new List<Motorcycle>();
            int pick = -1;

            while (pick != 0)
            {
                Console.WriteLine("1. View all vehicles.\n2. Add vehicle.\n3. Edit vehicle.\n" +
                                  "4. Delete vehicle.\n5. Vehicle information.\n0. Exit.");

                pick = IntCheck();

                switch (pick)
                {
                    case 1:
                        ViewAllVehicles(car, truck, motorcycle);

                        break;

                    case 2:
                        AddVehicle(car, truck, motorcycle);

                        break;

                    case 3:
                        EditVehicle(car, truck, motorcycle);

                        break;

                    case 4:
                        DeleteVehicle(car, truck, motorcycle);

                        break;

                    case 5:
                        VehicleInformation(car, truck, motorcycle);

                        break;
                }
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}