using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Lesson8
{
    internal class Program
    {
        static int Diference(int height, int width)
        {
            return height - width;  
        }

        static void Main(string[] args)
        {
            int deference = Diference(10, 5);
            Console.WriteLine(deference);

            int deference2 = Diference(width: 10, height: 5);
            Console.WriteLine(deference2);
        }
    }
}
