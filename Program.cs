using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _7._2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Maxym F.
            
            Part3();
        }

        public static void Part1() 
        {
            //Assignment 1


            for (int i = 10; i >= 0; i = i - 1) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Blast off.");

        
        }

        public static void Part2() 
        {
            //Assignment 2

            Console.WriteLine("x\t\ty");

            for (int i = -10; i <= 10; i = i + 2) 
            {
                
                Console.WriteLine(i + "\t\t" + ( i * i) );

            }

        }

        public static void Part3() 
        {
            //Assignment 3

            string name;

            Console.WriteLine("Whats you name?");
            name = Console.ReadLine();

            

            if (name == "Aldworth" || name == "aldworth")
            {
                for (int i = 1; i <= 5; i = i + 1)
                {

                    Console.WriteLine(i + ". " + name);

                }



            }

            else
            {

                for (int i = 1; i <= 10; i = i + 1)
                {

                    Console.WriteLine(i + ". " + name);

                }

            }

        }
     
        
    }
}
