using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable
            //int favoriteNumber;

            //to make an array, use the brackets;
            //good practice -- make array name effective to convey info.
            //good practice -- make sure array elements are releated

            //int[] favoriteNumbers = { 61, 22, 3, 44, 105, 36 };

            //// make a string array

            //string[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali" };

            //Console.WriteLine(studentNames[2]);

            // Excercise #1

            // Top 10 vacation spots

            //string[] vacationSpots = { "Cabo San Lucas", "The warehouse from _Big Trouble in Little China_",
            //    "Peurto Rico", "Quad Cities", "West 65th St.", "RRCS",
            //    "The Duck Tape Factory", "Pittsburgh", "Toronto", "San Francisco" };
            //Console.WriteLine(vacationSpots[0] + ", " + vacationSpots[9]);

            //// Prints age of 3 kids I know

            //int[] agesOfKids = { 3, 16, 25 };
            //Console.WriteLine(agesOfKids[0]);
            //Console.WriteLine(agesOfKids[1]);
            //Console.WriteLine(agesOfKids[2]);

            ////Prints GPAs on a 4.00 scale

            //float[] gpas = { 3.4f, 2.0f, 4.3f, 2.5f, 4.7f, 3.67f, 2f, 2.75f, 3.9f };
            //Console.WriteLine(gpas[1]);

            //// Prints first name of one of a peer

            //string[] studentsAround = { "Faize", "Brad", "Kathleen", "David" };
            //Console.WriteLine(studentsAround[0]);



            //How to add elements to an array when we don't know all the elements

            //Specifies an array with size of 4

            //Practicing default values of different data types

            int[] numbers = new int[4];
            numbers[0] = 43;
            numbers[1] = 12;
            Console.WriteLine("Please enter a number");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number");
            numbers[3] = int.Parse(Console.ReadLine());
            Console.WriteLine(numbers[2]);

            //char[] letters = new char [4];
            //letters[0] = 'a';
            //Console.WriteLine(letters[3]);

        }
    }
}
