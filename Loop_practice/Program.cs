using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace Loop_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x <= 5)
            {
                Console.WriteLine(x++);
            }

            Console.WriteLine("--------------------");

            string name = "Bryce";

            foreach(char character in name)
            {
                Console.WriteLine((int)character);
            }

            int testvalue;

            for (testvalue = 69; testvalue < 690; testvalue += 3)
            {
                Console.WriteLine(testvalue);
            }



            Console.WriteLine("-------------------------------------------------------");

            for(int i = 1;i < 4; i++)
            {
                Console.WriteLine("Loop Iteration Example:" + i);


                for (int j = 1; j < 4; j++)
                {
                    Console.WriteLine("Inner Loop Ilteration:" + j + "\t\t\t\t");

                }
            }





            Console.WriteLine("My attempt at nested loops:");
                for (int v = 10; v < 100; v += 10)
                {
                Console.WriteLine("Custom Outer Loop Example:" + v);
                Console.WriteLine("-----------------------------");

                for (int y = 100; y < 1000; y += 100) 
                { 
                Console.WriteLine("Custom Inner Loop Example:" + y);
                    Console.WriteLine("________________________________");

                }
            }


            List<string> alphabet = new List<string>()
            {
               "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
            };

            foreach(string letter in alphabet)
            {
                Console.WriteLine(letter);

            
            }

            Console.WriteLine("Let's try some capitalization");


            foreach(string capletter in alphabet)
            {
                Console.WriteLine(capletter.ToUpper());
                
            }


        }
    }
}
