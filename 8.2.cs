namespace ConsoleApp27
{
    public class Calendar
    {
        private int day;
        private int month;
        private int year;
        public int this[string date]
        {
            get
            {
                switch (date)
                {
                    case "day": return day;
                    case "month": return month;
                    case "year": return year;
                    default: return 0;
                }
            }
            set
            {
                switch (date)
                {
                    case "day":
                        day = value;
                        break;
                    case "month":
                        month = value;
                        break;
                    case "year":
                        year = value;
                        break;
                }
            }
        }

        public int Calculate(int Day, int Month, int Year)
        {
            int result = -1 * (Day - day + ((Month - month) * 30) + ((Year - year) * 365));
            return result;
        }
    }
}