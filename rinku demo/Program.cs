using System;

namespace rinku_demo
{

    class Program
    {
        public static void Main()
        {
            city obj = new city();
            obj.Add(1,2,3);
        }

    }
    class city
    {
        public void Add(int a, int b)// function overloding
        {
            
            int c = a + b;

            Console.WriteLine("Add is {0}", c);
        }
        public void Add(int p, int b, int a)
        {
           
            int m = a + b + p;
            Console.WriteLine("Add is {0}", m);
        }
    }
}


















