using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q112
{
    class Program
    {
        static void Main(string[] args)
        {
            questionA();
            //questionB();
            questionC();
            questionD();
            Console.ReadLine();
        }
        static void questionA()
        {
            Console.WriteLine("questionA:");
            string inputLine;
            using (StreamReader reader = new StreamReader("data.txt")) 
            {
                while ((inputLine = reader.ReadLine()) != null)
                {
                    Console.WriteLine(inputLine);
                }
            }
        }
        //static void questionB()
        //{
        //    Console.WriteLine("questionB:");
        //    string inputLine;
        //    StreamReader reader = null;
        //    using (reader = new StreamReader("data.txt")) ;  //<-- ERROR 

        //        while ((inputLine = reader.ReadLine()) != null)
        //        {
        //            Console.WriteLine(inputLine);
        //        }

        //}

        static void questionC()
        {
            Console.WriteLine("questionC:");
            string inputLine;
            StreamReader reader = new StreamReader("data.txt");
            while ((inputLine = reader.ReadLine()) != null)
            {
                Console.WriteLine(inputLine);
            }
        }
        static void questionD()
        {
            Console.WriteLine("questionD:");
            string inputLine;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("data.txt");
                while ((inputLine = reader.ReadLine()) != null)
                {
                    Console.WriteLine(inputLine);
                }
                reader.Close();
                reader.Dispose();
            }
            finally 
            { 
            }
        }

    }
}
