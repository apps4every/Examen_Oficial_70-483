using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q126
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPCION A:");
            Console.WriteLine( FormatCoins_A("JOSÉ PEREZ", 5));
            Console.WriteLine(FormatCoins_A("JOSÉ PEREZ", 0));
            Console.WriteLine(FormatCoins_A("JOSÉ PEREZ", 999));
            Console.WriteLine(FormatCoins_A("JOSÉ PEREZ", 1000));
            Console.WriteLine("OPCION B:");
            Console.WriteLine(FormatCoins_B("JOSÉ PEREZ", 5));
            Console.WriteLine(FormatCoins_B("JOSÉ PEREZ", 0));
            Console.WriteLine(FormatCoins_B("JOSÉ PEREZ", 999));
            Console.WriteLine(FormatCoins_B("JOSÉ PEREZ", 1000));
            //Console.WriteLine("OPCION C:");
            //Console.WriteLine(FormatCoins_C("JOSÉ PEREZ", 5));
            //Console.WriteLine(FormatCoins_C("JOSÉ PEREZ", 0));
            //Console.WriteLine("OPCION D:");
            //Console.WriteLine(FormatCoins_D("JOSÉ PEREZ", 5));
            //Console.WriteLine(FormatCoins_D("JOSÉ PEREZ", 0));
            Console.ReadLine();
        }
        static string FormatCoins_A(string name, int coins)
        {
            return String.Format("Player {0},collected {1}", name, coins.ToString("###0"));
        }

        static string FormatCoins_B(string name, int coins)
        {
            return String.Format("Player {0},collected {1:000#} coins.", name, coins);
        }
        //static string FormatCoins_C(string name, int coins)
        //{
        //    return String.Format("Player {name},collected {coins.ToString('000')} coins");
        //}
        //static string FormatCoins_D(string name, int coins)
        //{
        //    return String.Format("Player {1},collected {2:D3} coins", name, coins);
        //}
    }
}
