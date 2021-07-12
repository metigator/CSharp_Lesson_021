using System;

namespace CAInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc = new Subclass();
            Console.WriteLine(sc.value);
            Console.ReadKey();
        }

        class Baseclass
        {
            public int value = 10;
        }

        class Subclass: Baseclass
        {
            public int value = 20; 
        }
    }

}
