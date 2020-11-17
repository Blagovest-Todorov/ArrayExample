using System;

namespace _32.arrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = {1,2,3,4 }; // we creat an array of type int ; named numbers;//array of type int with name numbers!
            //Console.WriteLine(numbers); //string [] ;
            //int[] numbers = new int[5];
            //array --heap dynamic memory //
            //array lives into the heap memory, dynamic memory

            var daysOfWeek =  new string[]
            {       "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"
            };
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                Console.WriteLine("daysOfWeek[{0}] = {1}", i, daysOfWeek[i] );

            }
            Console.WriteLine("Today is {0}", daysOfWeek[-1]);
            
            
        }
    }
}
