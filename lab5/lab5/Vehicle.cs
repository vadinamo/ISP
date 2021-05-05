using System;

namespace lab5
{
    abstract class Vehicle //ТС -> (легковой автомобиль, грузовой автомобиоль, мотоцикл)
    {                     //CarType        LiftingCapacity       WheelCount
        private string _brand;
        private string _model;
        private float _engineVolume;
        private uint _yearOfIssue;
        private uint _mileage;
        private uint _topSpeed;
        private uint _price;

        public string Brand
        {
            get
            {
                return _brand;
            }

            set
            {
                _brand = value;
            }
        }
        
        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }
        
        public float EngineVolume
        {
            get
            {
                return _engineVolume;
            }

            set
            {
                _engineVolume = value;
            }
        }
        
        public uint YearOfIssue
        {
            get
            {
                return _yearOfIssue;
            }

            set
            {
                _yearOfIssue = value;
            }
        }

        public uint Mileage
        {
            get
            {
                return _mileage;
            }

            set
            {
                _mileage = value;
            }
        }
        
        public uint TopSpeed
        {
            get
            {
                return _topSpeed;
            }

            set
            {
                _topSpeed = value;
            }
        }
        
        public uint Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
        
        public Vehicle()    //конструктор по умолчанию
        {
            _brand = "";
            _model = "";
            _engineVolume = 0;
            _yearOfIssue = 0;
            _mileage = 0;
            _topSpeed = 0;
            _price = 0;
        }

        public Vehicle(string brand, string model, float engineVolume,
                   uint yearOfIssue, uint mileage, uint topSpeed, uint price)
        {
            this._brand = brand;
            this._model = model;
            this._engineVolume = engineVolume;
            this._yearOfIssue = yearOfIssue;
            this._mileage = mileage;
            this._topSpeed = topSpeed;
            this._price = price;
        }

        public uint PriceConvert(uint price)
        {
            double dollarRate = 2.6;
            uint dollarPrice = (uint)(price / dollarRate);

            return dollarPrice;
        }

        public virtual void Information()   //вывод информации по автомобилю
        {
            Console.WriteLine($"\nBrand: {_brand}\nModel: {_model}\nPrice: {_price}(BYN), {PriceConvert(_price)}(USD)\n" +
                              $"Engine volume: {_engineVolume}\nYear Of Issue: {_yearOfIssue}\n" +
                              $"Milleage: {_mileage}\nTop Speed: {_topSpeed}");
        }

        public void Information(int i)
        {
            Console.WriteLine((i + 1) + $".  {_brand}, {_model}, {PriceConvert(_price)}$");
        }
    }
}
