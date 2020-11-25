using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp17
{
    public class Rectangle
    {
        int x, y;
        //Конструкторы
        public Rectangle()
        {
            x = y = 0;
        }
        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //Вывод значений сторон a и b 
        public void Show()
        {
            Console.WriteLine("x = {0}, y = {1}", this.x, this.y);
        }
        //a. Индексатор
        public int this[int index]
        {
            get
            {
                if (index == 0) return this.x;
                else if (index == 1) return this.y;
                else return -1;
            }
            set
            {
                if (index == 0) this.x = value;
                else if (index == 1) this.y = value;
            }
        }
        //b.1 Перегрузка операторов инкремента и декремента
        public static Rectangle operator ++(Rectangle ob)
        {
            ob.x++;
            ob.y++;
            return ob;
        }
        public static Rectangle operator --(Rectangle ob)
        {
            ob.x--;
            ob.y--;
            return ob;
        }
        //b.2 Перегрузка констант true и false
        public static bool operator true(Rectangle ob)
        {
            return (ob.x == ob.y) ? true : false;
        }
        public static bool operator false(Rectangle ob)
        {
            return (ob.x != ob.y) ? true : false;
        }
        //b.3 Перегрузка операторов умножения Rectangle на скаляр
        public static Rectangle operator *(Rectangle ob, int i)
        {
            ob.x *= i;
            ob.y *= i;
            return ob;
        }
        public static Rectangle operator *(int i, Rectangle ob)
        {
            return (ob * i);
        }
        public override string ToString()
        {
            return x.ToString() + ", " + y.ToString();
        }

        public void StrToRect(string str)
        {
            string[] q = str.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            x = int.Parse(q[0]);
            y = int.Parse(q[1]);
        }
    }
    class Program
    {
        internal static void Main()
        {
            Rectangle r1 = new Rectangle(10, 20);
            // или другие операторы
            Console.WriteLine(r1 * 5);
            Console.WriteLine(r1[1]);
        }
    }
}