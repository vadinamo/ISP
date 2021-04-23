using System;
using System.Collections.Generic;

namespace lab5
{
    abstract class Vehicle //ТС -> (легковой автомобиль, грузовой автомобиоль, мотоцикл)
    {                     //CarType             LiftingCapacity       WheelCount
        public string Brand;
        public string Model;
        public float EngineVolume;
        public uint YearOfIssue;
        public uint Mileage;
        public uint TopSpeed;


        public Vehicle()    //конструктор по умолчанию
        {
            Brand = "";
            Model = "";
            EngineVolume = 0;
            YearOfIssue = 0;
            Mileage = 0;
            TopSpeed = 0;

        }

        public Vehicle(string brand, string model, float engineVolume,
                   uint yearOfIssue, uint mileage, uint topSpeed)
        {
            Brand = brand;
            Model = model;
            EngineVolume = engineVolume;
            YearOfIssue = yearOfIssue;
            Mileage = mileage;
            TopSpeed = topSpeed;
        }

        public void Information()   //вывод информации по автомобилю
        {
            Console.WriteLine($"\nBrand: {Brand}\nModel: {Model}\n" +
                              $"Engine volume: {EngineVolume}\nYear Of Issue: {YearOfIssue}\n" +
                              $"Milleage: {Mileage}\nTop Speed: {TopSpeed}");
        }

        public void Information(int i)
        {
            Console.WriteLine((i + 1) + $".  {Brand}, {Model}");
        }
    }
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
                   uint yearOfIssue, uint mileage, uint topSpeed,
                   string carType, uint doorCount) : base(brand, model, engineVolume,
                                                         yearOfIssue, mileage,
                                                         topSpeed)
        {
            CarType = carType;
            DoorCount = doorCount;
        }

        public new void Information()
        {
            base.Information();
            Console.WriteLine($"Car type: {CarType}\nDoor count: {DoorCount}\n");
        }
    }

    class Truck : Vehicle
    {
        public uint LiftingCapacity;
        public string Trailer;

        public Truck() : base()
        {
            LiftingCapacity = 0;
            Trailer = "";
        }
        public Truck(string brand, string model, float engineVolume,
                  uint yearOfIssue, uint mileage, uint topSpeed,
                  uint liftingCapacity, string trailer) : base(brand, model, engineVolume,
                                                        yearOfIssue, mileage,
                                                        topSpeed)
        {
            LiftingCapacity = liftingCapacity;
            Trailer = trailer;
        }

        public new void Information()
        {
            base.Information();
            Console.WriteLine($"Lifting capacity: {LiftingCapacity}\nTrailer: {Trailer}\n");
        }
    }

    class Motorcycle : Vehicle
    {
        public uint WheelCount;
        public string SideCar;

        public Motorcycle() : base()
        {
            WheelCount = 0;
            SideCar = "";
        }

        public Motorcycle(string brand, string model, float engineVolume,
                  uint yearOfIssue, uint mileage, uint topSpeed,
                  uint wheelCount, string sideCar) : base(brand, model, engineVolume,
                                                        yearOfIssue, mileage,
                                                        topSpeed)
        {
            WheelCount = wheelCount;
            SideCar = sideCar;
        }

        public new void Information()
        {
            base.Information();
            Console.WriteLine($"Wheel count: {WheelCount}\nSidecar: {SideCar}\n");
        }
    }

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

        static void ViewAllCars()
        {
            Console.WriteLine("Cars:");
            if (id_car != 0)
            {
                for (int i = 0; i < id_car; i++) //вывод марки и модели введенных автомобилей
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
            if (id_truck != 0)
            {
                for (int i = 0; i < id_truck; i++) //вывод марки и модели введенных автомобилей
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
            if (id_motorcycle != 0)
            {
                for (int i = 0; i < id_motorcycle; i++) //вывод марки и модели введенных автомобилей
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

        static void AddCar()
        {
            string brand, model, carType;
            float engineVolume;
            uint yearOfIssue, mileage, topSpeed, doorCount;
            Console.Write("Brand: ");
            brand = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Engine volume: ");
            engineVolume = FloatCheck();
            Console.Write("Year of issue:");
            yearOfIssue = UintCheck();
            Console.Write("Mileage:");
            mileage = UintCheck();
            Console.Write("Top speed:");
            topSpeed = UintCheck();
            Console.Write("Car type:");
            carType = Console.ReadLine();
            Console.Write("Door count:");
            doorCount = UintCheck();

            car.Add(new Car() //добавление объекта класса Car 
            {
                Brand = brand,
                Model = model,
                EngineVolume = engineVolume,
                YearOfIssue = yearOfIssue,
                Mileage = mileage,
                TopSpeed = topSpeed,
                CarType = carType,
                DoorCount = doorCount
            });
        }

        static void AddTruck()
        {
            string brand, model, trailer;
            float engineVolume;
            uint yearOfIssue, mileage, topSpeed, liftingCapacity;
            Console.Write("Brand: ");
            brand = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Engine volume: ");
            engineVolume = FloatCheck();
            Console.Write("Year of issue:");
            yearOfIssue = UintCheck();
            Console.Write("Mileage:");
            mileage = UintCheck();
            Console.Write("Top speed:");
            topSpeed = UintCheck();
            Console.Write("Trailer:");
            trailer = Console.ReadLine();
            Console.Write("Lifting capacity:");
            liftingCapacity = UintCheck();

            truck.Add(new Truck() //добавление объекта класса Car 
            {
                Brand = brand,
                Model = model,
                EngineVolume = engineVolume,
                YearOfIssue = yearOfIssue,
                Mileage = mileage,
                TopSpeed = topSpeed,
                LiftingCapacity = liftingCapacity,
                Trailer = trailer,
            });
        }

        static void AddMotorcycle()
        {
            string brand, model, sideCar;
            float engineVolume;
            uint yearOfIssue, mileage, topSpeed, wheelCount;
            Console.Write("Brand: ");
            brand = Console.ReadLine();
            Console.Write("Model: ");
            model = Console.ReadLine();
            Console.Write("Engine volume: ");
            engineVolume = FloatCheck();
            Console.Write("Year of issue:");
            yearOfIssue = UintCheck();
            Console.Write("Mileage:");
            mileage = UintCheck();
            Console.Write("Top speed:");
            topSpeed = UintCheck();
            Console.Write("Sidecar:");
            sideCar = Console.ReadLine();
            Console.Write("Wheel count:");
            wheelCount = UintCheck();

            motorcycle.Add(new Motorcycle() //добавление объекта класса Car 
            {
                Brand = brand,
                Model = model,
                EngineVolume = engineVolume,
                YearOfIssue = yearOfIssue,
                Mileage = mileage,
                TopSpeed = topSpeed,
                SideCar = sideCar,
                WheelCount = wheelCount,
            });
        }

        static void EditCar(int id)
        {
            int CarNumber;
            string brand, model, carType;
            float engineVolume;
            uint yearOfIssue, mileage, topSpeed, doorCount;
            Console.WriteLine("Enter car number.");
            CarNumber = IntCheck() - 1;
            if (CarNumber >= 0 && CarNumber < id)
            {
                Console.Write("Brand: ");
                brand = Console.ReadLine();
                Console.Write("Model: ");
                model = Console.ReadLine();
                Console.Write("Engine volume: ");
                engineVolume = FloatCheck();
                Console.Write("Year of issue:");
                yearOfIssue = UintCheck();
                Console.Write("Mileage:");
                mileage = UintCheck();
                Console.Write("Top speed:");
                topSpeed = UintCheck();
                Console.Write("Car type:");
                carType = Console.ReadLine();
                Console.Write("Door count:");
                doorCount = UintCheck();

                car[CarNumber].Brand = brand; //изменение полей объекта класса на введенные значения
                car[CarNumber].Model = model;
                car[CarNumber].EngineVolume = engineVolume;
                car[CarNumber].YearOfIssue = yearOfIssue;
                car[CarNumber].Mileage = mileage;
                car[CarNumber].TopSpeed = topSpeed;
                car[CarNumber].CarType = carType;
                car[CarNumber].DoorCount = doorCount;
            }

            else Console.WriteLine("Incorrect number");
        }

        static void EditTruck(int id)
        {
            int CarNumber;
            string brand, model, trailer;
            float engineVolume;
            uint yearOfIssue, mileage, topSpeed, liftingCapacity;
            Console.WriteLine("Enter car number.");
            CarNumber = IntCheck() - 1;

            if (CarNumber >= 0 && CarNumber < id)
            {
                Console.Write("Brand: ");
                brand = Console.ReadLine();
                Console.Write("Model: ");
                model = Console.ReadLine();
                Console.Write("Engine volume: ");
                engineVolume = FloatCheck();
                Console.Write("Year of issue:");
                yearOfIssue = UintCheck();
                Console.Write("Mileage:");
                mileage = UintCheck();
                Console.Write("Top speed:");
                topSpeed = UintCheck();
                Console.Write("Trailer:");
                trailer = Console.ReadLine();
                Console.Write("Lifting capacity:");
                liftingCapacity = UintCheck();

                truck[CarNumber].Brand = brand; //изменение полей объекта класса на введенные значения
                truck[CarNumber].Model = model;
                truck[CarNumber].EngineVolume = engineVolume;
                truck[CarNumber].YearOfIssue = yearOfIssue;
                truck[CarNumber].Mileage = mileage;
                truck[CarNumber].TopSpeed = topSpeed;
                truck[CarNumber].Trailer = trailer;
                truck[CarNumber].LiftingCapacity = liftingCapacity;
            }

            else Console.WriteLine("Incorrect number");
        }

        static void EditMotorcycle(int id)
        {
            int CarNumber;
            string brand, model, sideCar;
            float engineVolume;
            uint yearOfIssue, mileage, topSpeed, wheelCount;
            Console.WriteLine("Enter car number.");
            CarNumber = IntCheck() - 1;

            if (CarNumber >= 0 && CarNumber < id)
            {
                Console.Write("Brand: ");
                brand = Console.ReadLine();
                Console.Write("Model: ");
                model = Console.ReadLine();
                Console.Write("Engine volume: ");
                engineVolume = FloatCheck();
                Console.Write("Year of issue:");
                yearOfIssue = UintCheck();
                Console.Write("Mileage:");
                mileage = UintCheck();
                Console.Write("Top speed:");
                topSpeed = UintCheck();
                Console.Write("sideCar:");
                sideCar = Console.ReadLine();
                Console.Write("Wheel count:");
                wheelCount = UintCheck();

                motorcycle[CarNumber].Brand = brand; //изменение полей объекта класса на введенные значения
                motorcycle[CarNumber].Model = model;
                motorcycle[CarNumber].EngineVolume = engineVolume;
                motorcycle[CarNumber].YearOfIssue = yearOfIssue;
                motorcycle[CarNumber].Mileage = mileage;
                motorcycle[CarNumber].TopSpeed = topSpeed;
                motorcycle[CarNumber].SideCar = sideCar;
                motorcycle[CarNumber].WheelCount = wheelCount;
            }

            else Console.WriteLine("Incorrect number");

        }

        static void DeleteCar(int id)
        {
            int CarNumber;
            Console.WriteLine("Enter car number.");
            CarNumber = IntCheck() - 1;

            if (CarNumber >= 0 && CarNumber < id) //удаление объекта класса по указанному номера
                car.RemoveAt(CarNumber);

            else Console.WriteLine("Incorrect number.");
        }

        static void DeleteTruck(int id)
        {
            int CarNumber;
            Console.WriteLine("Enter truck number.");
            CarNumber = IntCheck() - 1;

            if (CarNumber >= 0 && CarNumber < id) //удаление объекта класса по указанному номера
                truck.RemoveAt(CarNumber);

            else Console.WriteLine("Incorrect number.");
        }

        static void DeleteMotorcycle(int id)
        {
            int CarNumber;
            Console.WriteLine("Enter motorcycle number.");
            CarNumber = IntCheck() - 1;

            if (CarNumber >= 0 && CarNumber < id) //удаление объекта класса по указанному номера
                motorcycle.RemoveAt(CarNumber);

            else Console.WriteLine("Incorrect number.");
        }

        static void CarInformation(int id)
        {
            int CarNumber;
            Console.WriteLine("Enter car number."); //вывод информации по автомобилю с указанным номером
            CarNumber = IntCheck() - 1;

            if (CarNumber >= 0 && CarNumber < id)
                car[CarNumber].Information();

            else Console.WriteLine("Incorrect number.");
        }

        static void TruckInformation(int id)
        {
            int CarNumber;
            Console.WriteLine("Enter truck number."); //вывод информации по автомобилю с указанным номером
            CarNumber = IntCheck() - 1;

            if (CarNumber >= 0 && CarNumber < id)
                truck[CarNumber].Information();

            else Console.WriteLine("Incorrect number.");
        }

        static void MotorcycleInformation(int id)
        {
            int CarNumber;
            Console.WriteLine("Enter motorcycle number."); //вывод информации по автомобилю с указанным номером
            CarNumber = IntCheck() - 1;

            if (CarNumber >= 0 && CarNumber < id)
                motorcycle[CarNumber].Information();

            else Console.WriteLine("Incorrect number.");
        }

        static void AddVehicle()
        {
            Console.WriteLine("1.Add car.\n2.Add truck.\n3.Add motorcycle.\n");
            operation = UintCheck();

            switch (operation)
            {
                case 1:
                    AddCar();
                    id_car++;
                    break;

                case 2:
                    AddTruck();
                    id_truck++;
                    break;

                case 3:
                    AddMotorcycle();
                    id_motorcycle++;
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        static void EditVehicle()
        {
            Console.WriteLine("1.Edit car.\n2.Edit truck.\n3.Edit motorcycle.\n");
            operation = UintCheck();
            switch (operation)
            {
                case 1:
                    EditCar(id_car);
                    break;

                case 2:
                    EditTruck(id_truck);
                    break;

                case 3:
                    EditMotorcycle(id_motorcycle);
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;

            }
        }
        static void DeleteVehicle()
        {
            Console.WriteLine("1.Delete car.\n2.Delete truck.\n3.Delete motorcycle.\n");
            operation = UintCheck();
            switch (operation)
            {
                case 1:
                    DeleteCar(id_car);
                    id_car--;
                    break;

                case 2:
                    DeleteTruck(id_truck);
                    id_truck--;
                    break;

                case 3:
                    DeleteMotorcycle(id_motorcycle);
                    id_motorcycle--;
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        static void VehicleInformation()
        {
            Console.WriteLine("1.Car information.\n2.Truck information.\n3.Motorcycle information.\n");
            operation = UintCheck();
            switch (operation)
            {
                case 1:
                    CarInformation(id_car);
                    break;

                case 2:
                    TruckInformation(id_truck);
                    break;

                case 3:
                    MotorcycleInformation(id_motorcycle);
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }

        static int id_car = 0, id_truck = 0, id_motorcycle = 0;
        static uint operation;
        static List<Car> car = new List<Car>();
        static List<Truck> truck = new List<Truck>();
        static List<Motorcycle> motorcycle = new List<Motorcycle>();

        static void Main(string[] args)
        {
            int pick = -1;

            while (pick != 0)
            {
                uint operation = 0;
                Console.WriteLine("1. View all vehicles.\n2. Add vehicle.\n3. Edit vehicle.\n" +
                                  "4. Delete vehicle.\n5. Vehicle information.\n0. Exit.");

                pick = IntCheck();

                switch (pick)
                {
                    case 1:
                        ViewAllCars();

                        break;

                    case 2:
                        AddVehicle();

                        break;

                    case 3:
                        EditVehicle();

                        break;

                    case 4:
                        DeleteVehicle();

                        break;

                    case 5:
                        VehicleInformation();

                        break;
                }
                Console.WriteLine("\n\n\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}