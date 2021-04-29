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
        public uint Price;


        public Vehicle()    //конструктор по умолчанию
        {
            Brand = "";
            Model = "";
            EngineVolume = 0;
            YearOfIssue = 0;
            Mileage = 0;
            TopSpeed = 0;
            Price = 0;
        }

        public Vehicle(string brand, string model, float engineVolume,
                   uint yearOfIssue, uint mileage, uint topSpeed, uint price)
        {
            Brand = brand;
            Model = model;
            EngineVolume = engineVolume;
            YearOfIssue = yearOfIssue;
            Mileage = mileage;
            TopSpeed = topSpeed;
            Price = price;
        }

        public uint PriceConvert(uint price)
        {
            double dollarRate = 2.6;
            uint dollarPrice = (uint)(price / dollarRate);

            return dollarPrice;
        }

        public virtual void Information()   //вывод информации по автомобилю
        {
            Console.WriteLine($"\nBrand: {Brand}\nModel: {Model}\nPrice: {Price}(BYN), {PriceConvert(Price)}(USD)\n" +
                              $"Engine volume: {EngineVolume}\nYear Of Issue: {YearOfIssue}\n" +
                              $"Milleage: {Mileage}\nTop Speed: {TopSpeed}");
        }

        public void Information(int i)
        {
            Console.WriteLine((i + 1) + $".  {Brand}, {Model}, {PriceConvert(Price)}$");
        }
    }
}
