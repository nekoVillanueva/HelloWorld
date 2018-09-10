﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            ////Part one  greetings statement
            //string messageOne = "Hello World";
            //String messageTwo = "I am Spartacus";

            //////Part two set initial Spartacus attributes
            //int ageOne = 35;
            //int ageTwo = 45;
            //int ageThree = 80;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.028461f;
            //float weightTwo = 331.123457f;
            //bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'F';

            //    //Part three display variable values
            //    Console.WriteLine(messageOne);//Displays initial greeting to console
            //    Console.WriteLine(messageTwo);

            //    //Part four mathematical operator, bool and char examples
            //    Console.WriteLine(ageOne+ageTwo);//addition example
            //    Console.WriteLine(heightOne-heightTwo);//substratction example
            //    Console.WriteLine(weightOne*weightTwo);//Multiplication example
            //    Console.WriteLine(isGodLikeOne);//bool example
            //    Console.WriteLine(genderMale);//char example

            //    //Part five variale reassignment
            //    ageTwo = 70;
            //    heightTwo = 35.12345f;
            //    weightTwo = -429.123456f;

            //    //Part six mathematical operator examples
            //    Console.WriteLine(ageOne + ageTwo);
            //    Console.WriteLine(heightOne - heightTwo);
            //    Console.WriteLine(weightOne * weightTwo);
            //    Console.WriteLine(ageTwo / ageOne);
            //    Console.WriteLine(ageTwo % ageOne);
            //    Console.WriteLine(ageThree / ageOne);
            //    Console.WriteLine(ageThree % ageOne);

            //    //Part seven increment and decrement operator examples
            //    ageTwo = ageTwo + 1;
            //    Console.WriteLine(ageTwo);
            //    ageTwo++;
            //    Console.WriteLine(ageTwo);
            //    ageTwo--;
            //    Console.WriteLine(ageTwo);
            //    Console.WriteLine(messageOne+messageTwo);
            //}

            //////Part eight concatenation example
            ////Console.WriteLine(messageOne + "" + messageTwo + ".");
            //Console.WriteLine("I am " + ageOne + " years old, and it is " + isGodLikeOne+" that I am godlike");
            //Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall");
            //Console.WriteLine("My father is {0} years old, and it is {1} that his is a god.", ageOne, isGodLikeOne);
            //Console.WriteLine("I weigh around {0} pounds, and I am around {1} inches tall" ,weightOne, heightOne);

            ////Part nine string equality examples

            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //    //Part ten string length examples
            //    int messOneLength = messageOne.Length;
            //    int messTwoLength = messageTwo.Length;

            //    Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //    Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //    Console.WriteLine("The length of messageOne is " + messOneLength);
            //    Console.WriteLine("The length of messageTwo is " + messTwoLength);


            ////}
            ////Part 11: Conditional examples

            //string cityOne = "Vesuvius";
            //string cityTwo = "Nola";
            //string cityThree = "Nuceria";
            //int cityOneDistance, cityTwoDistance, cityThreeDistance;

            ////Solicit user input
            //Console.WriteLine("What is the distance to {0}", cityOne);
            //cityOneDistance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + cityTwo + "?");
            //cityTwoDistance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //cityThreeDistance = int.Parse(Console.ReadLine());

            //if ((cityOneDistance <= 125) && ((cityOneDistance < cityTwoDistance) && (cityOneDistance < cityThreeDistance)))
            //{
            //    Console.WriteLine("We will march to {0}", cityOne);
            //}
            //if ((cityTwoDistance <= 125) && ((cityTwoDistance < cityOneDistance) && (cityTwoDistance < cityThreeDistance)))
            //{
            //    Console.WriteLine("We will march to" + cityTwo);
            //}
            //if ((cityThreeDistance <= 125) && ((cityThreeDistance < cityOneDistance) && (cityThreeDistance < cityTwoDistance)))
            //{
            //    Console.WriteLine("We will march to {0}", cityThree);
            ////}
            //Console.WriteLine("What is your rank?");
            //string rank = Console.ReadLine();

            //Console.WriteLine("What is your age?");
            //int age = int.Parse(Console.ReadLine());

            //if ((rank == "officer") || (age <= 26))
            //{
            //    Console.WriteLine("Get your gear, kiss your family goodbye, put on your marching boots.");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are staying home.");
            //}

            Console.WriteLine("What is your rank soldier?");
            string rank = Console.ReadLine().ToLower();

            Console.WriteLine("What is your age soldier?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your job soldier?");
            string job = Console.ReadLine().ToLower();

            if ((rank == "officer") || (age <= 26))
            {
                Console.WriteLine("Get your gear, kiss your family goodbye,put on your marching boots.");
            }
            else if ((job == "cook") && (age >= 26))
            {
                Console.WriteLine("My army has to eat. Pack your pots and pans.");
            }
            else
            {
                Console.WriteLine("Sorry, you are staying home.");
            }
            switch (job)
            {
                case "infantry":
                    Console.WriteLine("You will carry a sword.");
                    break;

                case "archer":
                    Console.WriteLine("You will carry a bow and arrow.");
                    break;

                case "supply":
                    Console.WriteLine("You will carry pots and pans.");
                    break;

                case "specialist":
                    Console.WriteLine("You will operate the catapult.");
                    break;

                default:
                    Console.WriteLine("You will ride horseback.");
                    break;
            }
        }
    }
}
