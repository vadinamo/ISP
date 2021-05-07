using System.Collections.Generic;

namespace lab6
{
    interface IComparer
    {
        int Compare(object o1, object o2);
        void SortByPrice(List<Vehicle> vehicle);
        void Swap<T>(IList<T> list, int indexA, int indexB);
    }
}