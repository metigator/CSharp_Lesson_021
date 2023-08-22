using System;

namespace CAInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Developer (1, "issam", 190, 10, true);

            System.Console.WriteLine(emp);
        }
    }
}
