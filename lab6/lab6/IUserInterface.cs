using System.Collections.Generic;
namespace lab6
{ 
    interface IUserInterface
    {
        uint UintCheck(); //проверка ввода uint
        int IntCheck();   //проверка ввода int
        float FloatCheck();   ////проверка ввода float
        void AddVehicle(List<Vehicle> vehicle);
        void EditVehicle(List<Vehicle> vehicle);
        void DeleteVehicle(List<Vehicle> vehicle);
        void VehicleInformation(List<Vehicle> vehicle);
        void ViewAllVehicles(List<Vehicle> vehicle);
    }
}