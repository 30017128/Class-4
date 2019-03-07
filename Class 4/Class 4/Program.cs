using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //bigger number 

            /*/ int num3 = 5;
            int num4 = 10;

            Console.WriteLine("Enter your first number");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 > num3 && num4 > num1)
            {
                Console.WriteLine("num1 is inbetween 5 and 10");
            }
            else
                {
                Console.WriteLine("num1 is not inbetween 5 and 10");
            }

            Console.WriteLine();

            Console.WriteLine("Enter your second number");
            int num2 = int.Parse(Console.ReadLine());

            

            Console.WriteLine();

            if (num1 > num2)
            {
                Console.WriteLine("The first number is bigger then the second number");
            }
        

            else if (num2 > num1)
            {
                Console.WriteLine("The second number is bigger then the first number");
            }

            else if (num1 == num2)
            {
                Console.WriteLine("The two numbers are equal");
            }
            Console.Read();

            if (num1 > num3 && num4 > num1)
            {
                Console.WriteLine("num1 is inbetween 5 and 10");
            } /*/



            //number randomiser

            /*/ Random rand = new Random();
            int myNum = rand.Next(1, 10);

            Console.WriteLine("Enter a number between 1 and 10");
            int userNum = int.Parse(Console.ReadLine());

            if (userNum == myNum)
            {
                Console.WriteLine("You guessed the number");
            }
            else if(userNum > myNum)
            {
                Console.WriteLine("Your guess is to high");
                Console.WriteLine("The number is:  " + myNum);
            }
            else if (userNum < myNum)
            {
                Console.WriteLine("Your guess is to low");
                Console.WriteLine("The number is:  " + myNum);
            }
            





            

            Console.ReadLine();

            /*/




            //Grade giver


            /*/ Console.WriteLine("Please enter your final grade");
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Your grade is A+ ");
            }
            else if (grade >= 80 && grade <=89)
            {

                Console.WriteLine("Your grade is A");
            }
            else if (grade >= 70 && grade <= 79)
            {

                Console.WriteLine("Your grade is B+");
            }
            else if (grade >= 60 && grade <= 69)
            {

                Console.WriteLine("Your grade is B");
            }
            else if (grade >= 50 && grade <= 59)
            {

                Console.WriteLine("Your grade is C");
            }
            else if (grade >= 40 && grade <= 49)
            {

                Console.WriteLine("Your grade is D");
            }
            else if (grade >= 0 && grade <= 39)
            {

                Console.WriteLine("Your grade is F");
            }

            Console.ReadLine();

    /*/


            //Odd or Even

            /*/
            Console.WriteLine("Please enter a odd or even number");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

            Console.ReadLine();
            /*/



            //Pin Number

            Console.WriteLine("Enter your pin");



        
        }
    }
}
