using System; //Транспортное средство – Автомобиль – Автомобили разных марок.
using System.Collections.Generic;

namespace lab3 //марка, объем, год выпуска, модель, пробег
{
    class Car
    {
        public string Brand;
        public string Model;
        public string CarType;
        public float EngineVolume;
        public uint YearOfIssue;
        public uint Mileage;
        public uint TopSpeed;


        public Car()    //конструктор по умолчанию
        {
            Brand = "";
            Model = "";
            CarType = "";
            EngineVolume = 0;
            YearOfIssue = 0;
            Mileage = 0;
            TopSpeed = 0;
            
        }

        public Car(string brand, string model, string carType,float engineVolume,
                   uint yearOfIssue, uint mileage, uint topSpeed)
        {
            Brand = brand;
            Model = model;
            CarType = carType;
            EngineVolume = engineVolume;
            YearOfIssue = yearOfIssue;
            Mileage = mileage;
            TopSpeed = topSpeed;
        }

        public void Information()   //вывод информации по автомобилю
        {
            Console.WriteLine($"\nBrand: {Brand}\nModel: {Model}\nCarType: {CarType}\n" +
                              $"Engine volume: {EngineVolume}\nYear Of Issue: {YearOfIssue}\n" +
                              $"Milleage: {Mileage}\n Top Speed: {TopSpeed}\n");
        }

        public void Information(int i)
        {
            Console.WriteLine((i) + $".  {Brand}, {Model}");
        }

        /*public void BrandEdit(string brand) => Brand = brand;

        public void ModelEdit(string model) => Model = model;

        public void CarTypeEdit(string carType) => CarType = carType;

        public void YearOfIssueEdit(uint yearOfIssue) => YearOfIssue = yearOfIssue;

        public void MileageEdit(uint mileage) => Mileage = mileage;

        public void TopSpeedEdit(uint topSpeed) => TopSpeed = topSpeed;

        public void EngineVolumeEdit(float engineVolume) => EngineVolume = engineVolume;*/
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

        static void Main(string[] args)
        {
            string brand, model, carType;
                        float engineVolume;
                        uint yearOfIssue, mileage, topSpeed;
            int CarNumber, id = 0;
            int pick = -1;

            List<Car> car = new List<Car>();
            while(pick != 0)
            {
                Console.WriteLine("1. View all cars.\n2. Add car.\n3. Edit car.\n4. Delete car.\n5. Car information.\n0. Exit.");
                pick = IntCheck();

                switch (pick)
                {
                    case 1:
                        if (id != 0)
                        {
                            Console.WriteLine();
                            for (int i = 0; i < id; i++) //вывод марки и модели введенных автомобилей
                            {
                                car[i].Information(i);
                            }
                            Console.WriteLine();
                        }

                        else
                        {
                            Console.WriteLine("There is no cars.\n");
                        }

                        break;

                    case 2:
                        Console.Write("Brand: ");
                        brand = Console.ReadLine();
                        Console.Write("Model: ");
                        model = Console.ReadLine();
                        Console.Write("Car Type: ");
                        carType = Console.ReadLine();
                        Console.Write("Engine volume: ");
                        engineVolume = FloatCheck();
                        Console.Write("Year of issue:");
                        yearOfIssue = UintCheck();
                        Console.Write("Mileage:");
                        mileage = UintCheck();
                        Console.Write("Top speed:");
                        topSpeed = UintCheck();

                        car.Add(new Car() //добавление объекта класса Car 
                        {
                            Brand = brand,
                            Model = model,
                            CarType = carType,
                            EngineVolume = engineVolume,
                            YearOfIssue = yearOfIssue,
                            Mileage = mileage,
                            TopSpeed = topSpeed
                        });
                        Console.WriteLine("\n\n");

                        id++;
                        break;

                    case 3:
                        Console.WriteLine("Enter car number.");
                        CarNumber = IntCheck();
                        if(CarNumber >= 0 && CarNumber < id)
                        {
                            Console.Write("Brand: ");
                            brand = Console.ReadLine();
                            Console.Write("Model: ");
                            model = Console.ReadLine();
                            Console.Write("Car Type: ");
                            carType = Console.ReadLine();
                            Console.Write("Engine volume: ");
                            engineVolume = FloatCheck();
                            Console.Write("Year of issue:");
                            yearOfIssue = UintCheck();
                            Console.Write("Mileage:");
                            mileage = UintCheck();
                            Console.Write("Top speed:");
                            topSpeed = UintCheck();

                            car[CarNumber].Brand = brand; //изменение полей объекта класса на введенные значения
                            car[CarNumber].Model = model;
                            car[CarNumber].CarType = carType;
                            car[CarNumber].EngineVolume = engineVolume;
                            car[CarNumber].YearOfIssue = yearOfIssue;
                            car[CarNumber].Mileage = mileage;
                            car[CarNumber].TopSpeed = topSpeed;
                        }

                        else Console.WriteLine("Incorrect number");

                        break;

                    case 4:
                        Console.WriteLine("Enter car number.");
                        CarNumber = IntCheck();

                        if (CarNumber >= 0 && CarNumber < id) //удаление объекта класса по указанному номера
                            car.RemoveAt(CarNumber);

                        else Console.WriteLine("Incorrect number.");

                        break;

                    case 5:
                        Console.WriteLine("Enter car number."); //вывод информации по автомобилю с указанным номером
                        CarNumber = IntCheck();

                        if (CarNumber >= 0 && CarNumber < id)
                            car[CarNumber].Information();

                        else Console.WriteLine("Incorrect number.");

                        break;
                }
            }
        }
    }
}
 