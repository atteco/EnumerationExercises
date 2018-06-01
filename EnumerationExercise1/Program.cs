using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationExercise1
{
    class Program
    {
        //some changes more to test git push
        static void Main(string[] args)
        {
            Console.WriteLine("väriyhdistelmät:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (Colours)val);

            Console.ReadLine();
        
        }
    }
}
