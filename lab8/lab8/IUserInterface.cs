using System.Collections.Generic;
namespace lab8
{ 
    interface IUserInterface
    {
        uint UIntCheck(); //проверка ввода uint
        int IntCheck();   //проверка ввода int
        double DoubleCheck();   ////проверка ввода float
        void AddVehicle(List<Vehicle> vehicle);
        void EditVehicle(List<Vehicle> vehicle);
        void DeleteVehicle(List<Vehicle> vehicle);
        void VehicleInformation(List<Vehicle> vehicle);
        void ViewAllVehicles(List<Vehicle> vehicle);
    }
}