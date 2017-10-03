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

            //int[] numbers = new int[4];
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number");
            //numbers[3] = int.Parse(Console.ReadLine());
            //Console.WriteLine(numbers[2]);

            //char[] letters = new char [4];
            //letters[0] = 'a';
            //Console.WriteLine(letters[3]);


            //Makes two arrays, name of students and days of the weeks

            //string[] daysOfWeek = new string [7];
            //daysOfWeek[0] = "Monday";
            //daysOfWeek[1] = "Tuesday";
            //daysOfWeek[2] = "Wednesday";
            //daysOfWeek[3] = "Thursday";
            //daysOfWeek[4] = "Friday";
            //daysOfWeek[5] = "Saturday";
            //daysOfWeek[6] = "Sunday";

            //int[] studentAges = new int[5];
            //studentAges[0] = 26;
            //studentAges[1] = 31;
            //studentAges[2] = 50;
            //studentAges[3] = 45;
            //studentAges[4] = 34;

            //Console.WriteLine(daysOfWeek.Length);


            //Make an array of my last name

            //char[] lastName = new char[9];
            //lastName[0] = 'G';
            //lastName[1] = 'i';
            //lastName[2] = 'l';
            //lastName[3] = 'f';
            //lastName[4] = 'e';
            //lastName[5] = 't';
            //lastName[6] = 'h';
            //lastName[7] = 'e';
            //lastName[8] = 'r';
            //Console.WriteLine(lastName.Length);


            //Prints out second to last string using .Length property
            //Length of Array - 1 == last item
            //Length of Array - 2 == second to last item
            //string[] threeBodyProblem = new string[5];
            //threeBodyProblem[0] = "Cixin";
            //threeBodyProblem[1] = "Liu";
            //threeBodyProblem[2] = "is";
            //threeBodyProblem[3] = "a";
            //threeBodyProblem[4] = "genius.";
            //Console.WriteLine(threeBodyProblem[threeBodyProblem.Length - 2]);


            //This is a list of names. I'll print the index of the third one.

            //string[] namesList = { "Brad", "Cheria", "Ali", "Ryan" };
            //Console.WriteLine(Array.IndexOf(namesList, "Ali"));



            // Making a copy of an array, print both

            //int[] someNums = { -4, 17, 230, 84, -84, 2983, 16, 20, 13, 6 };

            //int[] copyNums = new int[someNums.Length];

            //for (int index = 0; index < someNums.Length; index++)
            //{
            //    copyNums[index] = someNums[index];
            //}

            //for (int index =0; index <someNums.Length; index++)
            //{
            //    Console.Write(someNums[index] + "---" + copyNums[index]);
            //    Console.WriteLine();
            //}

            //Setting size of Array with user input
            //Console.WriteLine("Please enter size of an array");
            //int arraySize = int.Parse(Console.ReadLine());

            //int[] newArray = new int[arraySize];

            //Console.WriteLine("The array is of length " + newArray.Length);

            //Console.WriteLine(Array.IndexOf(newArray, newArray.Length));

            //Birth month example

            string[] birthMonths = { "October", "July", "October", "May" };

            //Helper method IndexOf -- Reports index in element in Array

            Console.WriteLine(Array.IndexOf(birthMonths, "October"));

            //LastIndexOf -- same, but last

            Console.WriteLine(Array.LastIndexOf(birthMonths, "October"));

            // Index of a string on an array element

            //Console.WriteLine(birthMonths[1].IndexOf("u"));

            int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            Console.WriteLine(Array.LastIndexOf(numbers, 4));



            


        }
    }
}
