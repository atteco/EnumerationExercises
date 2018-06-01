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
            var väri1 = (ColoursWithOutFlags)1;

            Console.WriteLine("väriyhdistelmät ilman Flags:eja:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (ColoursWithOutFlags)val);

            Console.WriteLine("väriyhdistelmät Flags:ien kanssa:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (ColoursWithFlags)val);

            Console.WriteLine();

            Console.WriteLine(väri1);

            Console.ReadLine();
        
        }
    }
}
