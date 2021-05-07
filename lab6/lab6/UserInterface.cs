using System;
using System.Collections.Generic;

namespace lab6
{
    public class UserInterface : IUserInterface, IComparer<Vehicle>
    {
        static string _brand, _model, _carType, _trailer, _sideCar, _type;
        static float _engineVolume;
        static uint _yearOfIssue, _mileage, _topSpeed, _doorCount, _price, _liftingCapacity, _wheelCount;
        public static UserInterface _userInterface;
        
        public int Compare(Vehicle a, Vehicle b)
        {
            if (a != null && b != null && a.Price < b.Price)
                return 1;
            else
                return 0;
        }
        public uint UintCheck() //проверка ввода uint
        {
            uint a;
            while (!uint.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Error!");
            }
            return a;
        }

        public int IntCheck()   //проверка ввода int
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Error!");
            }
            return a;
        }

        public float FloatCheck()   ////проверка ввода float
        {
            float a;
            while (!float.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Error!");
            }
            return a;
        }

        public void AddVehicle(List<Vehicle> vehicle)
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
                        Type = "Car"
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
                        Type = "Truck"
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
                        Type = "Motorcycle"
                    });
                    break;
            }
        }

        public void EditVehicle(List<Vehicle> vehicle)
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
                    case "Car":
                        Console.Write("Car type:");
                        _carType = Console.ReadLine();
                        Console.Write("Door count:");
                        _doorCount = UintCheck();
                        _type = "Car";
                    
                        vehicle[number] = new Car(_brand, _model, _engineVolume,
                            _yearOfIssue, _mileage, _topSpeed, _price, _type,
                            _carType, _doorCount);
                        break;

                    case "Truck":
                        Console.Write("Trailer:");
                        _trailer = Console.ReadLine();
                        Console.Write("Lifting capacity:");
                        _liftingCapacity = UintCheck();
                        _type = "Truck";

                        vehicle[number] = new Truck(_brand, _model, _engineVolume,
                            _yearOfIssue, _mileage, _topSpeed, _price, _type,
                            _liftingCapacity, _trailer);
                        break;

                    case "Motorcycle":
                        Console.Write("Sidecar:");
                        _sideCar = Console.ReadLine();
                        Console.Write("Wheel count:");
                        _wheelCount = UintCheck();
                        _type = "Motorcycle";

                        vehicle[number] = new Motorcycle(_brand, _model, _engineVolume,
                            _yearOfIssue, _mileage, _topSpeed, _price, _type,
                            _wheelCount, _sideCar);
                        break;
                }
            }
        }

        public void DeleteVehicle(List<Vehicle> vehicle)
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

        public void VehicleInformation(List<Vehicle> vehicle)
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
                    case "Car":
                        Car car = new Car(vehicle[number].Brand, vehicle[number].Model, vehicle[number].EngineVolume,
                            vehicle[number].YearOfIssue, vehicle[number].Mileage, vehicle[number].TopSpeed, 
                            vehicle[number].Price, vehicle[number].Type, vehicle[number].CarType, vehicle[number].DoorCount);
                        
                        car.Information();
                        break;

                    case "Truck":
                        Truck truck = new Truck(vehicle[number].Brand, vehicle[number].Model, vehicle[number].EngineVolume,
                            vehicle[number].YearOfIssue, vehicle[number].Mileage, vehicle[number].TopSpeed, vehicle[number].Price, 
                            vehicle[number].Type, vehicle[number].LiftingCapacity, vehicle[number].Trailer);
                        
                        truck.Information();
                        break;

                    case "Motorcycle":
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

        public void ViewAllVehicles(List<Vehicle> vehicle)
        {
            Console.WriteLine("Entered vehicles:");
            if (vehicle.Count != 0)
            {
                Car car = new Car();
                car.Information(vehicle);
                
                Truck truck = new Truck();
                truck.Information(vehicle);
                
                Motorcycle motorcycle = new Motorcycle();
                motorcycle.Information(vehicle);
            }
            else
            {
                Console.WriteLine("     No vehicles entered.");
            }
        }

        static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
        
        public void SortByPrice(List<Vehicle> vehicle)
        {
            int switches = 1;
            while (switches != 0)
            {
                switches = 0;
                for (int i = 0; i < vehicle.Count - 1; i++)
                {
                    if (_userInterface.Compare(vehicle[i], vehicle[i + 1]) == 1)
                    {
                        Swap(vehicle, i, i + 1);
                        switches++;
                    }
                }
            }

            for (int i = 0; i < vehicle.Count; i++)
            {
                vehicle[i].Information(i);
            }
        }
    }
}