using System;
using System.Collections.Generic;

namespace lab5
{ 
    class Program
    {
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
            string brand, model, carType, trailer, sideCar;
            float engineVolume;
            uint yearOfIssue, mileage, topSpeed, doorCount, price, liftingCapacity, wheelCount;

            Console.WriteLine("1.Add car.\n2.Add truck.\n3.Add motorcycle.\n");
            uint operation = UintCheck();

            if (operation != 1 && operation != 2 && operation != 3) //проверка ввода
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.Write("Brand: ");
            brand = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Price(BYN): ");
            price = UintCheck();
            Console.Write("Engine volume: ");
            engineVolume = FloatCheck();
            Console.Write("Year of issue:");
            yearOfIssue = UintCheck();
            Console.Write("Mileage:");
            mileage = UintCheck();
            Console.Write("Top speed:");
            topSpeed = UintCheck();

            switch(operation)
            {
                case 1:
                    Console.Write("Car type:");
                    carType = Console.ReadLine();
                    Console.Write("Door count:");
                    doorCount = UintCheck();

                    car.Add(new Car() //добавление объекта класса Car 
                    {
                        Brand = brand,
                        Model = model,
                        Price = price,
                        EngineVolume = engineVolume,
                        YearOfIssue = yearOfIssue,
                        Mileage = mileage,
                        TopSpeed = topSpeed,
                        CarType = carType,
                        DoorCount = doorCount
                    });
                    break;

                case 2:
                    Console.Write("Trailer:");
                    trailer = Console.ReadLine();
                    Console.Write("Lifting capacity:");
                    liftingCapacity = UintCheck();

                    truck.Add(new Truck() //добавление объекта класса Car 
                    {
                        Brand = brand,
                        Model = model,
                        Price = price,
                        EngineVolume = engineVolume,
                        YearOfIssue = yearOfIssue,
                        Mileage = mileage,
                        TopSpeed = topSpeed,
                        LiftingCapacity = liftingCapacity,
                        Trailer = trailer,
                    });
                    break;

                case 3:
                    Console.Write("Sidecar:");
                    sideCar = Console.ReadLine();
                    Console.Write("Wheel count:");
                    wheelCount = UintCheck();

                    motorcycle.Add(new Motorcycle() //добавление объекта класса Car 
                    {
                        Brand = brand,
                        Model = model,
                        Price = price,
                        EngineVolume = engineVolume,
                        YearOfIssue = yearOfIssue,
                        Mileage = mileage,
                        TopSpeed = topSpeed,
                        SideCar = sideCar,
                        WheelCount = wheelCount,
                    });
                    break;
            }
        }

        static void EditVehicle(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
        {
            string brand, model, carType, trailer, sideCar;
            float engineVolume;
            uint yearOfIssue, mileage, topSpeed, doorCount, price, liftingCapacity, wheelCount;

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
            brand = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Price(BYN): ");
            price = UintCheck();
            Console.Write("Engine volume: ");
            engineVolume = FloatCheck();
            Console.Write("Year of issue:");
            yearOfIssue = UintCheck();
            Console.Write("Mileage:");
            mileage = UintCheck();
            Console.Write("Top speed:");
            topSpeed = UintCheck();

            switch (operation)
            {
                case 1:
                    Console.Write("Car type:");
                    carType = Console.ReadLine();
                    Console.Write("Door count:");
                    doorCount = UintCheck();

                    car[number].Brand = brand; //изменение полей объекта класса на введенные значения
                    car[number].Model = model;
                    car[number].Price = price;
                    car[number].EngineVolume = engineVolume;
                    car[number].YearOfIssue = yearOfIssue;
                    car[number].Mileage = mileage;
                    car[number].TopSpeed = topSpeed;
                    car[number].CarType = carType;
                    car[number].DoorCount = doorCount;

                    break;

                case 2:
                    Console.Write("Trailer:");
                    trailer = Console.ReadLine();
                    Console.Write("Lifting capacity:");
                    liftingCapacity = UintCheck();

                    truck[number].Brand = brand; //изменение полей объекта класса на введенные значения
                    truck[number].Model = model;
                    truck[number].Price = price;
                    truck[number].EngineVolume = engineVolume;
                    truck[number].YearOfIssue = yearOfIssue;
                    truck[number].Mileage = mileage;
                    truck[number].TopSpeed = topSpeed;
                    truck[number].Trailer = trailer;
                    truck[number].LiftingCapacity = liftingCapacity;

                    break;

                case 3:
                    Console.Write("Sidecar:");
                    sideCar = Console.ReadLine();
                    Console.Write("Wheel count:");
                    wheelCount = UintCheck();

                    motorcycle[number].Brand = brand; //изменение полей объекта класса на введенные значения
                    motorcycle[number].Model = model;
                    motorcycle[number].Price = price;
                    motorcycle[number].EngineVolume = engineVolume;
                    motorcycle[number].YearOfIssue = yearOfIssue;
                    motorcycle[number].Mileage = mileage;
                    motorcycle[number].TopSpeed = topSpeed;
                    motorcycle[number].SideCar = sideCar;
                    motorcycle[number].WheelCount = wheelCount;

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