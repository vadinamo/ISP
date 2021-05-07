using System.Collections.Generic;
namespace lab6
{
    class TestAdd
    {
        public void TestVehicles(List<Vehicle> vehicle)
        {
            vehicle.Add(new Car() //добавление объекта класса Car 
            {
                Brand = "Volkswagen",
                Model = "Passat B6",
                Price = 16500,
                EngineVolume = 1.6,
                YearOfIssue = 2008,
                Mileage = 130000,
                TopSpeed = 190,
                CarType = "Sedan",
                DoorCount = 4,
                Type = "Car"
            });
            
            vehicle.Add(new Car() //добавление объекта класса Car 
            {
                Brand = "Audi",
                Model = "TT 8J",
                Price = 25400,
                EngineVolume = 2,
                YearOfIssue = 2006,
                Mileage = 146000,
                TopSpeed = 240,
                CarType = "Coupe",
                DoorCount = 2,
                Type = "Car"
            });
            
            vehicle.Add(new Car() //добавление объекта класса Car 
            {
                Brand = "Honda",
                Model = "Civic 6",
                Price = 6500,
                EngineVolume = 2,
                YearOfIssue = 1998,
                Mileage = 201000,
                TopSpeed = 180,
                CarType = "Hatchback",
                DoorCount = 5,
                Type = "Car"
            });
            
            vehicle.Add(new Truck() //добавление объекта класса Car 
            {
                Brand = "Volvo",
                Model = "FH XXL",
                Price = 26000,
                EngineVolume = 12.8,
                YearOfIssue = 2019,
                Mileage = 20000,
                TopSpeed = 120,
                LiftingCapacity = 6600,
                Trailer = "Cargo",
                Type = "Truck"
            });
            
            vehicle.Add(new Motorcycle() //добавление объекта класса Car 
            {
                Brand = "Kawasaki",
                Model = "ZZR 1200",
                Price = 10440,
                EngineVolume = 1.2,
                YearOfIssue = 2003,
                Mileage = 33000,
                TopSpeed = 300,
                SideCar = "-",
                WheelCount = 2,
                Type = "Motorcycle"
            });
            
            vehicle.Add(new Motorcycle() //добавление объекта класса Car 
            {
                Brand = "Suzuki",
                Model = "GSR 600",
                Price = 8790,
                EngineVolume = 0.6,
                YearOfIssue = 2006,
                Mileage = 34500,
                TopSpeed = 251,
                SideCar = "-",
                WheelCount = 2,
                Type = "Motorcycle"
            });
        }
    }
}