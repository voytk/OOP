namespace ConsoleApp30
{
    public class A
    {
        private int[] arr;

        public int Length
        {
            get
            {
                return arr.Length;
            }
        }

        public int this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }


    }
}
