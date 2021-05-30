using System;
using System.Collections.Generic;

namespace lab8
{
    public class UserInterface : IUserInterface, IComparer<Vehicle>
    {
        static string _brand, _model, _carType, _trailer, _sideCar, _type;
        static double _engineVolume;
        static uint _yearOfIssue, _mileage, _topSpeed, _doorCount, _price, _liftingCapacity, _wheelCount;

        public void Test(List<Vehicle> vehicle)
        {
            uint pick = 0;
            
            while (pick != 1 && pick != 2)
            {
                Console.WriteLine("Add vehicles?\n1.Yes.\n2.No.\n");
                pick = UIntCheck();
            }
            
            TestAdd test = new TestAdd();
            
            if (pick == 1)
            {
                test.TestVehicles(vehicle);
            }
        }
        public static uint UIntCheck() //проверка ввода uint
        {
            uint a;
            while (!uint.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Error!");
            }
            return a;
        }

        uint IUserInterface.UIntCheck()
        {
            return UIntCheck();
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
        
        int IUserInterface.IntCheck()
        {
            return IntCheck();
        }
        
        public static double DoubleCheck()   ////проверка ввода double
        {
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))//проверка ввода
            {
                Console.WriteLine("Error!");
            }
            return a;
        }
        
        double IUserInterface.DoubleCheck()
        {
            return DoubleCheck();
        }

        private static void Input()
        {
            Console.Write("Brand: ");
            _brand = Console.ReadLine();
            Console.Write("Model: ");
            _model = Console.ReadLine();
            Console.Write("Price(BYN): ");
            _price = UIntCheck();
            Console.Write("Engine volume: ");
            _engineVolume = DoubleCheck();
            
            try
            {
                if (_engineVolume < 0.1) throw new Exception();
            }

            catch (Exception)
            {
                while (_engineVolume < 0.1)
                {
                    Console.WriteLine("Incorrect wheel count input!");
                    _engineVolume = DoubleCheck();
                }
            }
            
            Console.Write("Year of issue:");
            _yearOfIssue = UIntCheck();
            
            try
            {
                if (_yearOfIssue < 1885) throw new Exception();
            }

            catch (Exception)
            {
                while (_yearOfIssue < 1885)
                {
                    Console.WriteLine("Incorrect wheel count input!");
                    _yearOfIssue = UIntCheck();
                }
            }
            
            Console.Write("Mileage:");
            _mileage = UIntCheck();
            Console.Write("Top speed:");
            _topSpeed = UIntCheck();
        }
        
        private static void CInput()
        {
            Console.Write("Car type:");
            _carType = Console.ReadLine();
            Console.Write("Door count:");
            _doorCount = UIntCheck();
            _type = "Car";
        }
        
        private static void TInput()
        {
            Console.Write("Trailer:");
            _trailer = Console.ReadLine();
            Console.Write("Lifting capacity:");
            _liftingCapacity = UIntCheck();
            _type = "Truck";
        }
        
        private static void MInput()
        {
            Console.Write("Sidecar:");
            _sideCar = Console.ReadLine();
            Console.Write("Wheel count:");
            _wheelCount = UIntCheck();
            _type = "Motorcycle";
            
            try
            {
                if (_wheelCount > 3) throw new Exception();
            }

            catch (Exception)
            {
                while (_wheelCount > 3)
                {
                    Console.WriteLine("Incorrect wheel count input!");
                    _wheelCount = UIntCheck();
                }
            }
        }

        public Vehicle.Input carInput = () =>
        {
            Input();
            CInput();
        };
        
        public Vehicle.Input truckInput = () =>
        {
            Input();
            TInput();
        };
        public Vehicle.Input motorcycleInput = () =>
        {
            Input();
            MInput();
        };

        public void AddVehicle(List<Vehicle> vehicle)
        { 
            Console.WriteLine("1.Add car.\n2.Add truck.\n3.Add motorcycle.\n");
            uint operation = UIntCheck();

            if (operation != 1 && operation != 2 && operation != 3) //проверка ввода
            {
                Console.WriteLine("Error!");
                return;
            }
            
            switch(operation)
            {
                case 1:
                    carInput();
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
                    truckInput();
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
                    motorcycleInput();
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
                switch (vehicle[number].Type)
                {
                    case "Car":
                        carInput();
                    
                        vehicle[number] = new Car(_brand, _model, _engineVolume,
                            _yearOfIssue, _mileage, _topSpeed, _price, _type,
                            _carType, _doorCount);
                        break;

                    case "Truck":
                        truckInput();

                        vehicle[number] = new Truck(_brand, _model, _engineVolume,
                            _yearOfIssue, _mileage, _topSpeed, _price, _type,
                            _liftingCapacity, _trailer);
                        break;

                    case "Motorcycle":
                        motorcycleInput();

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
                        Car car = (Car) vehicle[number];
                        car.Information();
                        break;

                    case "Truck":
                        Truck truck = (Truck) vehicle[number];
                        truck.Information();
                        break;

                    case "Motorcycle":
                        Motorcycle motorcycle = (Motorcycle) vehicle[number];
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
        
        public int Compare(Vehicle p1, Vehicle p2)
        {
            if (p1.Price < p2.Price)
                return 1;
            else
                return 0;
        }

        public void SortByPrice(List<Vehicle> vehicle)
        {
            int switches = 1;
            
            while (switches != 0)
            {
                switches = 0;
                for (int i = 0; i < vehicle.Count - 1; i++)
                {
                    if(Compare(vehicle[i], vehicle[i + 1]) == 1)
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