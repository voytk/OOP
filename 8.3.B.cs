using System;
using System.Linq;

namespace ConsoleApp30
{
    public class B : A
    {
        private char[] array;

        public int[] length
        {
            get
            {
                return new int[] { array.Length, base.Length };
            }
        }
        public char this[char index]
        {
            get
            {
                return array[Array.IndexOf(array, index)];
            }
            set
            {
                array[Array.IndexOf(array, index)] = value;
            }

        }
    }
}
