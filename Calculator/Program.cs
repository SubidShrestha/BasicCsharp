using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            calculate<double> c = new calculate<double>(10.0,15.0);
            Console.WriteLine(c.add());
            Console.WriteLine(c.subtract());
            Console.WriteLine(c.multiply());
            Console.WriteLine(c.divide());
            Console.ReadKey();
        }
    }
}
