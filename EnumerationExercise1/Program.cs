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
            int värinumero = 1;
            var väri = (ColoursWithOutFlags)värinumero;

            Console.WriteLine("väriyhdistelmät ilman Flags:eja:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (ColoursWithOutFlags)val);

            Console.ReadLine();

            Console.WriteLine("\nväriyhdistelmät Flags:ien kanssa:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (ColoursWithFlags)val);

            Console.WriteLine();

            Console.WriteLine("\nväri numero {0} ColoursWithOutFlags enumeraatiosta: {1} ", värinumero, väri );

            Console.WriteLine("\nvärit ColoursWithFlags:sta foreach:lla: ");
            foreach(var item in Enum.GetValues(typeof(ColoursWithFlags)))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        
        }
    }
}
