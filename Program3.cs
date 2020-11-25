﻿using System;

namespace ConsoleApp19
{
    class Matrix
    {
        private int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            set
            {
                numbers[i, j] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Console.WriteLine(matrix[0, 0]);
            matrix[0, 0] = 111;
            Console.WriteLine(matrix[0, 0]);
        }
    }
}
