using System;
using System.Collections.Generic;

namespace lab5
{
    class Program
    {
        static string _brand, _model, _carType, _trailer, _sideCar;
        static float _engineVolume;
        static uint _yearOfIssue, _mileage, _topSpeed, _doorCount, _price, _liftingCapacity, _wheelCount, _type;
        static uint UintCheck() //проверка ввода uint
        {
            uint a;
            while (!uint.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Error!");
            }
            return a;
        }

        static int IntCheck()   //проверка ввода int
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Error!");
            }
            return a;
        }

        static float FloatCheck()   ////проверка ввода float
        {
            float a;
            while (!float.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Error!");
            }
            return a;
        }

        static void AddVehicle(List<Vehicle> vehicle)
        { 
            Console.WriteLine("1.Add car.\n2.Add truck.\n3.Add motorcycle.\n");
            uint operation = UintCheck();

            if (operation != 1 && operation != 2 && operation != 3) //проверка ввода
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.Write("Brand: ");
            _brand = Console.ReadLine();
            Console.Write("Model: ");
            _model = Console.ReadLine();
            Console.Write("Price(BYN): ");
            _price = UintCheck();
            Console.Write("Engine volume: ");
            _engineVolume = FloatCheck();
            Console.Write("Year of issue:");
            _yearOfIssue = UintCheck();
            Console.Write("Mileage:");
            _mileage = UintCheck();
            Console.Write("Top speed:");
            _topSpeed = UintCheck();

            switch(operation)
            {
                case 1:
                    Console.Write("Car type:");
                    _carType = Console.ReadLine();
                    Console.Write("Door count:");
                    _doorCount = UintCheck();

                    vehicle.Add(new Car() //добавление объекта класса Car 
                    {
                        Brand = _brand,
                        Model = _model,
                        Price = _price,
                        EngineVolume = _engineVolume,
                        YearOfIssue = _yearOfIssue,
                        Mileage = _mileage,
                        TopSpeed = _topSpeed,
                        CarType = _carType,
                        DoorCount = _doorCount,
                        Type = 1
                    });
                    break;

                case 2:
                    Console.Write("Trailer:");
                    _trailer = Console.ReadLine();
                    Console.Write("Lifting capacity:");
                    _liftingCapacity = UintCheck();

                    vehicle.Add(new Truck() //добавление объекта класса Car 
                    {
                        Brand = _brand,
                        Model = _model,
                        Price = _price,
                        EngineVolume = _engineVolume,
                        YearOfIssue = _yearOfIssue,
                        Mileage = _mileage,
                        TopSpeed = _topSpeed,
                        LiftingCapacity = _liftingCapacity,
                        Trailer = _trailer,
                        Type = 2
                    });
                    break;

                case 3:
                    Console.Write("Sidecar:");
                    _sideCar = Console.ReadLine();
                    Console.Write("Wheel count:");
                    _wheelCount = UintCheck();

                    vehicle.Add(new Motorcycle() //добавление объекта класса Car 
                    {
                        Brand = _brand,
                        Model = _model,
                        Price = _price,
                        EngineVolume = _engineVolume,
                        YearOfIssue = _yearOfIssue,
                        Mileage = _mileage,
                        TopSpeed = _topSpeed,
                        SideCar = _sideCar,
                        WheelCount = _wheelCount,
                        Type = 3
                    });
                    break;
            }
        }

        static void EditVehicle(List<Vehicle> vehicle)
        { 
            Console.WriteLine("Enter vehicle number.");
            int number = IntCheck() - 1;

            if (number < 0 || number >= vehicle.Count)
            {
                Console.WriteLine("Incorrect number!");
            }

            else
            {
                Console.Write("Brand: ");
                _brand = Console.ReadLine();
                Console.Write("Model: ");
                _model = Console.ReadLine();
                Console.Write("Price(BYN): ");
                _price = UintCheck();
                Console.Write("Engine volume: ");
                _engineVolume = FloatCheck();
                Console.Write("Year of issue:");
                _yearOfIssue = UintCheck();
                Console.Write("Mileage:");
                _mileage = UintCheck();
                Console.Write("Top speed:");
                _topSpeed = UintCheck();

                switch (vehicle[number].Type)
                {
                    case 1:
                        Console.Write("Car type:");
                        _carType = Console.ReadLine();
                        Console.Write("Door count:");
                        _doorCount = UintCheck();
                        _type = 1;
                    
                        vehicle[number] = new Car(_brand, _model, _engineVolume,
                            _yearOfIssue, _mileage, _topSpeed, _price, _type,
                            _carType, _doorCount);
                        break;

                    case 2:
                        Console.Write("Trailer:");
                        _trailer = Console.ReadLine();
                        Console.Write("Lifting capacity:");
                        _liftingCapacity = UintCheck();
                        _type = 2;

                        vehicle[number] = new Truck(_brand, _model, _engineVolume,
                            _yearOfIssue, _mileage, _topSpeed, _price, _type,
                            _liftingCapacity, _trailer);
                        break;

                    case 3:
                        Console.Write("Sidecar:");
                        _sideCar = Console.ReadLine();
                        Console.Write("Wheel count:");
                        _wheelCount = UintCheck();
                        _type = 3;

                        vehicle[number] = new Motorcycle(_brand, _model, _engineVolume,
                            _yearOfIssue, _mileage, _topSpeed, _price, _type,
                            _wheelCount, _sideCar);
                        break;
                }
            }
        }

        static void DeleteVehicle(List<Vehicle> vehicle)
        {
            Console.WriteLine("Enter vehicle number.");
            int number = IntCheck() - 1;

            if (number < 0 || number >= vehicle.Count)
            {
                Console.WriteLine("Incorrect number!");
            }

            else
            {
                vehicle.RemoveAt(number);
                Console.WriteLine("Success");
            }

        }

        static void VehicleInformation(List<Vehicle> vehicle)
        {
            Console.WriteLine("Enter vehicle number.");
            int number = IntCheck() - 1;

            if (number < 0 || number >= vehicle.Count)
            {
                Console.WriteLine("Incorrect number!");
            }

            else
            {
                switch (vehicle[number].Type)
                {
                    case 1:
                        Car car = new Car(vehicle[number].Brand, vehicle[number].Model, vehicle[number].EngineVolume,
                            vehicle[number].YearOfIssue, vehicle[number].Mileage, vehicle[number].TopSpeed, 
                            vehicle[number].Price, vehicle[number].Type, vehicle[number].CarType, vehicle[number].DoorCount);
                        
                        car.Information();
                        break;

                    case 2:
                        Truck truck = new Truck(vehicle[number].Brand, vehicle[number].Model, vehicle[number].EngineVolume,
                            vehicle[number].YearOfIssue, vehicle[number].Mileage, vehicle[number].TopSpeed, vehicle[number].Price, 
                            vehicle[number].Type, vehicle[number].LiftingCapacity, vehicle[number].Trailer);
                        
                        truck.Information();
                        break;

                    case 3:
                        Motorcycle motorcycle = new Motorcycle(vehicle[number].Brand, vehicle[number].Model, vehicle[number].EngineVolume,
                            vehicle[number].YearOfIssue, vehicle[number].Mileage, vehicle[number].TopSpeed, vehicle[number].Price, 
                            vehicle[number].Type, vehicle[number].WheelCount, vehicle[number].SideCar);
                        motorcycle.Information();
                        break;

                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }

        static void ViewAllVehicles(List<Vehicle> vehicle)
        {
            Console.WriteLine("Entered vehicles:");
            if (vehicle.Count != 0)
            {
                for (int i = 0; i < vehicle.Count; i++) //вывод марки, модели и цены введенных автомобилей
                {
                    vehicle[0].Information(i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("     No vehicles entered.");
            }
        }

        static void Main()
        {
            List<Vehicle> vehicle = new List<Vehicle>();
            int pick = -1;

            while (pick != 0)
            {
                Console.WriteLine("1. View all vehicles.\n2. Add vehicle.\n3. Edit vehicle.\n" +
                                  "4. Delete vehicle.\n5. Vehicle information.\n0. Exit.");

                pick = IntCheck();

                switch (pick)
                {
                    case 1:
                        ViewAllVehicles(vehicle);

                        break;

                    case 2:
                        AddVehicle(vehicle);

                        break;

                    case 3:
                        EditVehicle(vehicle);

                        break;

                    case 4:
                        DeleteVehicle(vehicle);

                        break;

                    case 5:
                        VehicleInformation(vehicle);

                        break;
                }
                Console.WriteLine("\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}