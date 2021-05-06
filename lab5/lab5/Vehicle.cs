using System;

namespace lab5
{
    struct Charast
    {
        public string Brand, Model;
        public float EngineVolume;
        public uint YearOfIssue, Mileage, TopSpeed, Price, Type;
    }
    
    abstract class Vehicle //ТС -> (легковой автомобиль, грузовой автомобиоль, мотоцикл)
    {                     //CarType        LiftingCapacity       WheelCount
        private Charast _vehicle;

        private string _carType;
        private uint _doorCount;
        private uint _wheelCount;
        private string _sideCar;
        private uint _liftingCapacity;
        private string _trailer;
        
        public uint LiftingCapacity
        {
            get
            {
                return _liftingCapacity;
            }

            set
            {
                _liftingCapacity = value;
            }
        }
        
        public string Trailer
        {
            get
            {
                return _trailer;
            }

            set
            {
                _trailer = value;
            }
        }

        
        public uint WheelCount
        {
            get
            {
                return _wheelCount;
            }

            set
            {
                _wheelCount = value;
            }
        }
        
        public string SideCar
        {
            get
            {
                return _sideCar;
            }

            set
            {
                _sideCar = value;
            }
        }

        public string CarType
        {
            get
            {
                return _carType;
            }

            set
            {
                _carType = value;
            }
        }
        
        public uint DoorCount
        {
            get
            {
                return _doorCount;
            }

            set
            {
                _doorCount = value;
            }
        }

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
        
        public uint Type
        {
            get
            {
                return _vehicle.Type;
            }

            set
            {
                _vehicle.Type = value;
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
            _vehicle.Price = 0;
            _vehicle.Type = 0;
        }

        public Vehicle(string brand, string model, float engineVolume,
                   uint yearOfIssue, uint mileage, uint topSpeed, uint price, uint type)
        {
            _vehicle.Brand = brand;
            _vehicle.Model = model;
            _vehicle.EngineVolume = engineVolume;
            _vehicle.YearOfIssue = yearOfIssue;
            _vehicle.Mileage = mileage;
            _vehicle.TopSpeed = topSpeed;
            _vehicle.Price = price;
            _vehicle.Type = type;
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
