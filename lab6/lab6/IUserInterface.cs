using System;
using System.Collections.Generic;

namespace lab6
{
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
            static string _brand, _model, _carType, _trailer, _sideCar;
            static float _engineVolume;
            static uint _yearOfIssue, _mileage, _topSpeed, _doorCount, _price, _liftingCapacity, _wheelCount;
            
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
            
                                car.Add(new Car() //добавление объекта класса Car 
                                {
                                    Brand = _brand,
                                    Model = _model,
                                    Price = _price,
                                    EngineVolume = _engineVolume,
                                    YearOfIssue = _yearOfIssue,
                                    Mileage = _mileage,
                                    TopSpeed = _topSpeed,
                                    CarType = _carType,
                                    DoorCount = _doorCount
                                });
                                break;
            
                            case 2:
                                Console.Write("Trailer:");
                                _trailer = Console.ReadLine();
                                Console.Write("Lifting capacity:");
                                _liftingCapacity = UintCheck();
            
                                truck.Add(new Truck() //добавление объекта класса Car 
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
                                });
                                break;
            
                            case 3:
                                Console.Write("Sidecar:");
                                _sideCar = Console.ReadLine();
                                Console.Write("Wheel count:");
                                _wheelCount = UintCheck();
            
                                motorcycle.Add(new Motorcycle() //добавление объекта класса Car 
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
            
                        switch (operation)
                        {
                            case 1:
                                Console.Write("Car type:");
                                _carType = Console.ReadLine();
                                Console.Write("Door count:");
                                _doorCount = UintCheck();
            
                                car[number].Brand = _brand; //изменение полей объекта класса на введенные значения
                                car[number].Model = _model;
                                car[number].Price = _price;
                                car[number].EngineVolume = _engineVolume;
                                car[number].YearOfIssue = _yearOfIssue;
                                car[number].Mileage = _mileage;
                                car[number].TopSpeed = _topSpeed;
                                car[number].CarType = _carType;
                                car[number].DoorCount = _doorCount;
            
                                break;
            
                            case 2:
                                Console.Write("Trailer:");
                                _trailer = Console.ReadLine();
                                Console.Write("Lifting capacity:");
                                _liftingCapacity = UintCheck();
            
                                truck[number].Brand = _brand; //изменение полей объекта класса на введенные значения
                                truck[number].Model = _model;
                                truck[number].Price = _price;
                                truck[number].EngineVolume = _engineVolume;
                                truck[number].YearOfIssue = _yearOfIssue;
                                truck[number].Mileage = _mileage;
                                truck[number].TopSpeed = _topSpeed;
                                truck[number].Trailer = _trailer;
                                truck[number].LiftingCapacity = _liftingCapacity;
            
                                break;
            
                            case 3:
                                Console.Write("Sidecar:");
                                _sideCar = Console.ReadLine();
                                Console.Write("Wheel count:");
                                _wheelCount = UintCheck();
            
                                motorcycle[number].Brand = _brand; //изменение полей объекта класса на введенные значения
                                motorcycle[number].Model = _model;
                                motorcycle[number].Price = _price;
                                motorcycle[number].EngineVolume = _engineVolume;
                                motorcycle[number].YearOfIssue = _yearOfIssue;
                                motorcycle[number].Mileage = _mileage;
                                motorcycle[number].TopSpeed = _topSpeed;
                                motorcycle[number].SideCar = _sideCar;
                                motorcycle[number].WheelCount = _wheelCount;
            
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