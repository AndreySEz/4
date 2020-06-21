using System;

namespace ООП_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Health h1 = new Health();
            h1.Temp = 60;
            Console.WriteLine(h1.Temp);
            Book b1 = new Book();
            b1.Year = 2076;
            Console.WriteLine(b1.Year);
        }
        class Health
        {
            private int temp;
            public int Temp
            {
                get
                {
                    return temp;
                }
                set
                {
                    if (value > 41) temp = 41;
                    else if (value < 34) temp = 34;
                    else temp = value;
                }
            }
        }
        class Book
        {
            private int year;
            public int Year
            {
                get
                {
                    return year;
                }
                set
                {
                    if (value > 2020) year = 2020;
                    else if (value < 1940) year = 1940;
                    else year = value;
                }
            }
        }
    }
}
