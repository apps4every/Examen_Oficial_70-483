using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q265
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solución oficial:");
            int[] intArray = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] += intArray[i];
            }
            foreach (var item in intArray)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("Solución correcta:");
            int[] intArray2 = { 1, 2, 3, 4, 5 };
            for (int i = 1; i < intArray2.Length; i++)
            {                
                intArray2[i] += intArray2[i - 1];
            }
            foreach (var item in intArray2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
