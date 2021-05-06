using System;

namespace lab6
{
    struct Charast
    {
        public string Brand, Model;
        public float EngineVolume;
        public uint YearOfIssue, Mileage, TopSpeed, Price;
    }
    
    public abstract class Vehicle //ТС -> (легковой автомобиль, грузовой автомобиоль, мотоцикл)
    {                     //CarType        LiftingCapacity       WheelCount
        private Charast _vehicle;

        public string Brand
        {
            get
            {
                return _vehicle.Brand;
            }

            set
            {
                _vehicle.Brand = value;
            }
        }
        
        public string Model
        {
            get
            {
                return _vehicle.Model;
            }

            set
            {
                _vehicle.Model = value;
            }
        }
        
        public float EngineVolume
        {
            get
            {
                return _vehicle.EngineVolume;
            }

            set
            {
                _vehicle.EngineVolume = value;
            }
        }
        
        public uint YearOfIssue
        {
            get
            {
                return _vehicle.YearOfIssue;
            }

            set
            {
                _vehicle.YearOfIssue = value;
            }
        }

        public uint Mileage
        {
            get
            {
                return _vehicle.Mileage;
            }

            set
            {
                _vehicle.Mileage = value;
            }
        }
        
        public uint TopSpeed
        {
            get
            {
                return _vehicle.TopSpeed;
            }

            set
            {
                _vehicle.TopSpeed = value;
            }
        }
        
        public uint Price
        {
            get
            {
                return _vehicle.Price;
            }

            set
            {
                _vehicle.Price = value;
            }
        }
        
        public Vehicle()    //конструктор по умолчанию
        {
            _vehicle.Brand = "";
            _vehicle.Model = "";
            _vehicle.EngineVolume = 0;
            _vehicle.YearOfIssue = 0;
            _vehicle.Mileage = 0;
            _vehicle.TopSpeed = 0;
            _vehicle. Price = 0;
        }

        public Vehicle(string brand, string model, float engineVolume,
                   uint yearOfIssue, uint mileage, uint topSpeed, uint price)
        {
            _vehicle.Brand = brand;
            _vehicle.Model = model;
            _vehicle.EngineVolume = engineVolume;
            _vehicle.YearOfIssue = yearOfIssue;
            _vehicle.Mileage = mileage;
            _vehicle.TopSpeed = topSpeed;
            _vehicle.Price = price;
        }

        public uint PriceConvert(uint price)
        {
            double dollarRate = 2.6;
            uint dollarPrice = (uint)(price / dollarRate);

            return dollarPrice;
        }

        public virtual void Information()   //вывод информации по автомобилю
        {
            Console.WriteLine(
                $"\nBrand: {_vehicle.Brand}\nModel: {_vehicle.Model}\nPrice: {_vehicle.Price}(BYN), {PriceConvert(_vehicle.Price)}(USD)\n" +
                $"Engine volume: {_vehicle.EngineVolume}\nYear Of Issue: {_vehicle.YearOfIssue}\n" +
                $"Milleage: {_vehicle.Mileage}\nTop Speed: {_vehicle.TopSpeed}");
        }

        public void Information(int i)
        {
            Console.WriteLine((i + 1) + $".  {_vehicle.Brand}, {_vehicle.Model}, {PriceConvert(_vehicle.Price)}$");
        }
    }
}
