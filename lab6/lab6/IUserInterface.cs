using System;
using System.Collections.Generic;

namespace lab6
{
    struct Charast
    {
        public string Brand, Model, CarType, Trailer, SideCar;
        public float EngineVolume;
        public uint YearOfIssue, Mileage, TopSpeed, DoorCount, Price, LiftingCapacity, WheelCount;
    }

    interface IUserInterface
        {
            uint UintCheck(); //проверка ввода uint
            int IntCheck();   //проверка ввода int
            float FloatCheck();   ////проверка ввода float
            void EditVehicle(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle);
            void DeleteVehicle(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle);
            void VehicleInformation(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle);
            void ViewAllVehicles(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle);
        }

    public class UserInterface : IUserInterface
        {
            static Charast _vehicle;
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
    
            public void AddVehicle(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
            { 
                Console.WriteLine("1.Add car.\n2.Add truck.\n3.Add motorcycle.\n");
                uint operation = UintCheck();
    
                if (operation != 1 && operation != 2 && operation != 3) //проверка ввода
                {
                    Console.WriteLine("Error!");
                    return;
                }
    
                Console.Write("Brand: ");
                _vehicle.Brand = Console.ReadLine();
                Console.Write("Model: ");
                _vehicle.Model = Console.ReadLine();
                Console.Write("Price(BYN): ");
                _vehicle.Price = UintCheck();
                Console.Write("Engine volume: ");
                _vehicle.EngineVolume = FloatCheck();
                Console.Write("Year of issue:");
                _vehicle.YearOfIssue = UintCheck();
                Console.Write("Mileage:");
                _vehicle.Mileage = UintCheck();
                Console.Write("Top speed:");
                _vehicle.TopSpeed = UintCheck();
    
                switch(operation)
                {
                    case 1:
                        Console.Write("Car type:");
                        _vehicle.CarType = Console.ReadLine();
                        Console.Write("Door count:");
                        _vehicle.DoorCount = UintCheck();
    
                        car.Add(new Car() //добавление объекта класса Car 
                        {
                            Brand = _vehicle.Brand,
                            Model = _vehicle.Model,
                            Price = _vehicle.Price,
                            EngineVolume = _vehicle.EngineVolume,
                            YearOfIssue = _vehicle.YearOfIssue,
                            Mileage = _vehicle.Mileage,
                            TopSpeed = _vehicle.TopSpeed,
                            CarType = _vehicle.CarType,
                            DoorCount = _vehicle.DoorCount
                        });
                        break;
    
                    case 2:
                        Console.Write("Trailer:");
                        _vehicle.Trailer = Console.ReadLine();
                        Console.Write("Lifting capacity:");
                        _vehicle.LiftingCapacity = UintCheck();
    
                        truck.Add(new Truck() //добавление объекта класса Car 
                        {
                            Brand = _vehicle.Brand,
                            Model = _vehicle.Model,
                            Price = _vehicle.Price,
                            EngineVolume = _vehicle.EngineVolume,
                            YearOfIssue = _vehicle.YearOfIssue,
                            Mileage = _vehicle.Mileage,
                            TopSpeed = _vehicle.TopSpeed,
                            LiftingCapacity = _vehicle.LiftingCapacity,
                            Trailer = _vehicle.Trailer,
                        });
                        break;
    
                    case 3:
                        Console.Write("Sidecar:");
                        _vehicle.SideCar = Console.ReadLine();
                        Console.Write("Wheel count:");
                        _vehicle.WheelCount = UintCheck();
    
                        motorcycle.Add(new Motorcycle() //добавление объекта класса Car 
                        {
                            Brand = _vehicle.Brand,
                            Model = _vehicle.Model,
                            Price = _vehicle.Price,
                            EngineVolume = _vehicle.EngineVolume,
                            YearOfIssue = _vehicle.YearOfIssue,
                            Mileage = _vehicle.Mileage,
                            TopSpeed = _vehicle.TopSpeed,
                            SideCar = _vehicle.SideCar,
                            WheelCount = _vehicle.WheelCount,
                        });
                        break;
                }
            }
    
            public void EditVehicle(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
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
                _vehicle.Brand = Console.ReadLine();
                Console.Write("Model: ");
                _vehicle.Model = Console.ReadLine();
                Console.Write("Price(BYN): ");
                _vehicle.Price = UintCheck();
                Console.Write("Engine volume: ");
                _vehicle.EngineVolume = FloatCheck();
                Console.Write("Year of issue:");
                _vehicle.YearOfIssue = UintCheck();
                Console.Write("Mileage:");
                _vehicle.Mileage = UintCheck();
                Console.Write("Top speed:");
                _vehicle.TopSpeed = UintCheck();
    
                switch (operation)
                {
                    case 1:
                        Console.Write("Car type:");
                        _vehicle.CarType = Console.ReadLine();
                        Console.Write("Door count:");
                        _vehicle.DoorCount = UintCheck();
    
                        car[number].Brand = _vehicle.Brand; //изменение полей объекта класса на введенные значения
                        car[number].Model = _vehicle.Model;
                        car[number].Price = _vehicle.Price;
                        car[number].EngineVolume = _vehicle.EngineVolume;
                        car[number].YearOfIssue = _vehicle.YearOfIssue;
                        car[number].Mileage = _vehicle.Mileage;
                        car[number].TopSpeed = _vehicle.TopSpeed;
                        car[number].CarType = _vehicle.CarType;
                        car[number].DoorCount = _vehicle.DoorCount;
    
                        break;
    
                    case 2:
                        Console.Write("Trailer:");
                        _vehicle.Trailer = Console.ReadLine();
                        Console.Write("Lifting capacity:");
                        _vehicle.LiftingCapacity = UintCheck();
    
                        truck[number].Brand = _vehicle.Brand; //изменение полей объекта класса на введенные значения
                        truck[number].Model = _vehicle.Model;
                        truck[number].Price = _vehicle.Price;
                        truck[number].EngineVolume = _vehicle.EngineVolume;
                        truck[number].YearOfIssue = _vehicle.YearOfIssue;
                        truck[number].Mileage = _vehicle.Mileage;
                        truck[number].TopSpeed = _vehicle.TopSpeed;
                        truck[number].Trailer = _vehicle.Trailer;
                        truck[number].LiftingCapacity = _vehicle.LiftingCapacity;
    
                        break;
    
                    case 3:
                        Console.Write("Sidecar:");
                        _vehicle.SideCar = Console.ReadLine();
                        Console.Write("Wheel count:");
                        _vehicle.WheelCount = UintCheck();
    
                        motorcycle[number].Brand = _vehicle.Brand; //изменение полей объекта класса на введенные значения
                        motorcycle[number].Model = _vehicle.Model;
                        motorcycle[number].Price = _vehicle.Price;
                        motorcycle[number].EngineVolume = _vehicle.EngineVolume;
                        motorcycle[number].YearOfIssue = _vehicle.YearOfIssue;
                        motorcycle[number].Mileage = _vehicle.Mileage;
                        motorcycle[number].TopSpeed = _vehicle.TopSpeed;
                        motorcycle[number].SideCar = _vehicle.SideCar;
                        motorcycle[number].WheelCount = _vehicle.WheelCount;
    
                        break;
                }
            }
    
            public void DeleteVehicle(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
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
                        }
    
                        else
                        {
                            motorcycle.RemoveAt(number);
                            Console.WriteLine("Success");
                        }
    
                        break;
                }
    
            }
    
            public void VehicleInformation(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
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
    
            public void ViewAllVehicles(List<Car> car, List<Truck> truck, List<Motorcycle> motorcycle)
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
    
        }
}