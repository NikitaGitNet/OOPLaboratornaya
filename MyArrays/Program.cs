using System;

namespace MyArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrays arrays = new Arrays();
            arrays.GetValues(arrays.Array1);
            arrays.GetValues(arrays.Array2);
            //arrays.Array1[0, 1] = 99;
            arrays.CheckSymmetry(arrays.Array1, arrays.Array2, arrays.IsSymmetry);
            arrays.SumArrays(arrays.Array1, arrays.Array2);
            arrays.SubArrays(arrays.Array1, arrays.Array2);
        }
    }
}
