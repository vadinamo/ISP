using System;
using System.Collections.Generic;

namespace lab6
{
    interface IComparer
    {
        int Compare(object o1, object o2);
    }

    class VehicleComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle a, Vehicle b)
        {
            if (a != null && b != null && a.Price < b.Price)
                return 1;
            else
                return 0;
        }
    }
}