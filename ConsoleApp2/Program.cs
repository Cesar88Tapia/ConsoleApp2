using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            decimal x = 0.0m;
            float f = 0.0f;
            double d = 0.0D;
            string cadena = "Hello world";
            bool bandera = false;
            DateTime fecha = DateTime.MinValue;
            Console.WriteLine("The value of i is: {0}", i);
            Console.WriteLine("The value of x is: {0:c}", x);
            Console.WriteLine("The value of f is: {0:F2}", f);
            Console.WriteLine("The value of d is: {0:F2}", d);
            Console.WriteLine("The value of cadena is: " + cadena);
            Console.WriteLine("The value of bandera is: " + bandera.ToString());
            Console.WriteLine("The value of fecha is: " + fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}
