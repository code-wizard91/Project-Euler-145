using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1. List Reversable Numbers");
            Console.WriteLine("2. Reverse Number ");
            Console.WriteLine("3. Odd Number Detector");

            //below we take the input from the user which is required by the switch case.
            string s = Console.ReadLine();
            int n = int.Parse(s); //we parse the integer so it can be used with the switch



            

            switch (n)
            {
                case 1:
                  
                    //unsolved question 1


                    break;
                case 2:

                    Console.WriteLine("Enter a Number to reverse"); // Give the user a Prompt
                    int Number = int.Parse(Console.ReadLine()); //here we take the users input and send it to our Reverse Method
                    ReverseNumber(Number); //Here we send the number entered by the user to our method.

                    break;

                case 3:

                    Console.WriteLine("Enter a Number to see if it is odd");    // Give the user a Prompt
                    int UserNum = int.Parse(Console.ReadLine());    //here we take the users input and send it to our Reverse Method
                    IsOdd(UserNum); //Here we send the number entered by the user to our method.
                    break;


                default:
                    Console.WriteLine("Invalid selection."); //show when user makes the wrong choice
                    break;

            }

            Console.ReadLine(); //stops program from closing
        }

        public static bool IsOdd(int num) //returns true if number is odd
        {

            if (num % 2 == 0)
            {
                //number is even
                Console.WriteLine("FALSE Number Is even");
                return false;

            }
            else
            {

                Console.WriteLine("TRUE Number is odd");
                return true;
            }


        }

        public static int ReverseNumber(int Number) // reverses input number and returns it.
        {
                    
                    int Reverse = 0;
                    while (Number > 0)
                    {
                        int remainder = Number % 10;
                        Reverse = (Reverse * 10) + remainder;
                        Number = Number / 10;
                    }
                    Console.WriteLine("Reverse No. is {0}", Reverse);


            return Reverse;
        }

        //Here is my failed attempt at question one.

        //private static Array[] isReversible(int n)
        //{

        //    int number = n;
        //    int[] oddreversedValues;


        //    //Check 0 in the end
        //    if (n % 10 == 0);

        //    //Reverse the number
        //    int reversed = 0;
        //    while (number > 0)
        //    {
        //        reversed = 10 * reversed + number % 10;
        //        number /= 10;
        //    }

        //    //Add the original and reversed
        //    reversed += n;

        //    //Check if all digits are odd
        //    while (reversed > 0)
        //    {
        //        if ((reversed % 10) % 2 == 0);
        //        oddreversedValues[] = reversed /= 10;
        //    }

        //    return oddreversedValues[];
            
        //}



    }
}
