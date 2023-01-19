using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrays
{
    internal class Arrays
    {
        public int[,] Array1 = new int[3,3];
        public int[,] Array2 = new int[3,3];
        public bool IsSymmetry { get; set; }
        public int[,] GetValues(int[,] Array)
        {
            Array[0, 0] = 1;
            Array[0, 1] = 2;
            Array[0, 2] = 3;
            Array[1, 0] = 4;
            Array[1, 1] = 5;
            Array[1, 2] = 6;
            Array[2, 0] = 7;
            Array[2, 1] = 8;
            Array[2, 2] = 9;
            return Array;
        }
        public void CheckSymmetry(int[,] Array1, int[,] Array2, bool IsSymmetry)
        {
            IsSymmetry = true;
            for (int i = 0; i < Array1.GetLength(0); i++)
            {
                if (!IsSymmetry)
                {
                    Console.WriteLine("Массивы не симметричны");
                    break; 
                }
                for (int j = 0; j < Array1.GetLength(1); j++)
                {
                    if (Array1[i, j] == Array2[i, j])
                    {
                        IsSymmetry = true;
                    }
                    else
                    {
                        IsSymmetry = false;
                        break;
                    }
                }
            }
            if (IsSymmetry)
            {
                Console.WriteLine("Массивы симметричны");
            }
        }
        public int[,] SumArrays(int[,] Array1, int[,] Array2)
        {
            for (int i = 0; i < Array1.GetLength(0); i++)
            {
                for (int j = 0; j < Array1.GetLength(1); j++)
                {
                    Array1[i, j] += Array2[i, j];
                    Console.WriteLine(Array1[i, j]);
                }
            }
            return Array1;
        }
        public int[,] SubArrays(int[,] Array1, int[,] Array2)
        {
            for (int i = 0; i < Array1.GetLength(0); i++)
            {
                for (int j = 0; j < Array1.GetLength(1); j++)
                {
                    Array1[i, j] -= Array2[i, j];
                    Console.WriteLine(Array1[i, j]);
                }
            }
            return Array1;
        }
    }
}
