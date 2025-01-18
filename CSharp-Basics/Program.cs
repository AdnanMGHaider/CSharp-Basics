using System.Collections.Concurrent;

namespace CSharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World, My name is Adnan Haider.");

            //Console.ReadLine();

            /////Numeric Data Types/////

            //Console.WriteLine("int");
            //int age;
            //int age2 = 23;
            //int age3 = -23;
            //Console.WriteLine($"Age1: {age2}, Age2: {age3}");
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(int.MaxValue);

            //Console.WriteLine("Long");
            //long bigNumber = 900000000L;
            //Console.WriteLine(bigNumber);
            //Console.WriteLine(long.MinValue);
            //Console.WriteLine(long.MaxValue);

            //Console.WriteLine("Float");
            //float precision = 5.000001F;
            //Console.WriteLine(precision);
            //Console.WriteLine(float.MinValue);
            //Console.WriteLine(float.MaxValue);

            //Console.WriteLine("Double");
            //double negative = -55.2;
            //Console.WriteLine(double.MinValue);
            //Console.WriteLine(double.MaxValue);

            //Highest precision, suitable for financial and monetary calculation.
            //Console.WriteLine("Decimal");
            //decimal money = 14.99M;
            //Console.WriteLine(decimal.MinValue);
            //Console.WriteLine(decimal.MaxValue);

            /////Declaring Variables/////

            //int x = 20;
            //int y = 30;
            //int z = 40;

            //int x = 90, y = 80, z = 70;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //y = 115;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);


            /////Strings and Characters/////
            //You cannot use single quotations for string type
            //string name = "Aba";
            //char letter = 'a';
            //Console.WriteLine(name);
            //Console.WriteLine(letter);

            //string myName = "My name is Adnan. ";
            //string myAge = "I'm 33 years old";
            //Console.Write(myName);
            //Console.Write(myAge);

            //string emptyString = "";

            /////Converting string to int/////
            //string stringInt = "-23";
            //int convertedStringToInt = Convert.ToInt32(stringInt);
            //Console.WriteLine(convertedStringToInt);

            /////Converting string to other numeric data types/////
            //string stringBigNumber = "90000000"; //No need to put L in this case.
            //long convertedStringToLong = Convert.ToInt64(stringBigNumber);
            //Console.WriteLine(convertedStringToLong);

            //string stringDouble = "55.2";
            //double convertedStringToDouble = Convert.ToDouble(stringDouble);
            //Console.WriteLine(convertedStringToDouble);

            //string stringFloat = "45.2";
            //double convertedStringToFloat = Convert.ToSingle(stringFloat);
            //Console.WriteLine(convertedStringToFloat);

            //string stringDecimal = "7.29";
            //decimal convertedStringToDecimal = Convert.ToDecimal(stringDecimal);
            //Console.WriteLine(convertedStringToDecimal);

            /////Boolean Data Type/////
            //bool value = true;

            //bool isMale = true;

            //Console.WriteLine(isMale);

            /////Operators/////
            //int age = 33;
            //age++;
            //Console.WriteLine(age);
            //age--;
            //Console.WriteLine(age);
            //age = age + 5;
            //Console.WriteLine(age);
            //age += 1;
            //Console.WriteLine(age);

            //age++, age = age + 1, and age += 1 all do the same thing


            //age -= 1;
            //age *= 5;
            //age /= 7;

            //int i = 5;
            //int result1 = i++;
            //Console.WriteLine(result1); // Prints 5 and then increases the value from 5 to 6 internally
            //int result2 = ++i;
            //Console.WriteLine(result2); // 6 becomes 7 internally, and then 7 gets printed


            //int randomNumber = 9;
            //randomNumber /= 2;
            //Console.WriteLine(randomNumber); //The result is 4, and .5 is truncated.

            //double randomNumber2 = 7;
            //randomNumber2 /= 2;
            //Console.WriteLine(randomNumber2); //Now the result is not truncated to remove numbers after decimal

            /////String Concatenation/////
            //string name = "Adnan";
            //name += " is a Computer Programmer";
            //Console.WriteLine(name);

            /////Modulus/////
            //int firstNum = 10;
            //int secondNum = 3;

            //Console.WriteLine(firstNum / secondNum);
            //Console.WriteLine(firstNum % secondNum);

            /////Var Keyword: Type is inferred at compile time/////
            //var age = 23;
            //var bigNumber = 900000L;
            //var negative = -55.2D;
            //var precision = 5.00000001F;
            //var money = 14.99M;
            //var name = "Adnan";
            //var letter = "A";

            /////Const/////
            //const int vat = 20;
            //Console.WriteLine(vat);
            //vat = 30; //Cannot reassign

            //int balance = 1000;

            //Console.WriteLine(balance * (vat / 100D));

            //Exercise 1
            /*
             * Define a variable to hold your name
             * Define a variable to hold your phone number
             * Define a variable to hold your age
             * Print variables line-by-line to th screen
             * Extra: define variables using the var keyword.
             * 
             */


            //string myName = "Adnan";
            //The reason the number is stored as a string is so that if the first number is 0,
            //it does not get cut out.
            //string myNumber = "26732550";
            //int myAge = 33;

            //Console.WriteLine(myName);
            //Console.WriteLine(myNumber);
            //Console.WriteLine(myAge);


            //Exercise 2
            /*
             * Create and initialize 2 ints
             * Make a variable to work out the remainder
             * Output remainder to screen 
             * Change the first int variable to another number
                * and recalculate the remainder
                * output new remainder to the screen
             */

            //int num1 = 7;
            //int num2 = 3;

            //int remainder = num1 % num2;
            //Console.WriteLine(remainder);

            //num1 = 12;
            //remainder = num1 % num2;
            //Console.WriteLine(remainder);

            /////Console Input/Output/////
            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Your name is " + name);

            ////Console.Write() Does not push everything after to the next line.
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is " + age);

            //Console.WriteLine("Your name is " + name + " and your age is " + age);

            /////If Statements/////

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            Console.WriteLine("Your name is " + name + " and your age is " + age);

            //==, >, >=, <, <=, !=, ||, &&

            
              if (age >= 18 && age <= 25)
            {
                Console.WriteLine("You are between 18 and 25");
            }
            else if (age >= 26)
            {
                Console.WriteLine("You are 26 or older");
            }



            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 or older");
                }
            }

            Console.WriteLine("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);


            Console.WriteLine("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            Console.WriteLine("Value of " + numberA + " x " + numberB + ": ");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (answer == actualAnswer)
            {
                Console.WriteLine("Well done!");
            }
            else
            {
                Console.WriteLine("Close but it was wrong!");
            }

            ///Switch Statements/////
            Console.WriteLine("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Mon");
                    break;
                case 2:
                    Console.WriteLine("Tue");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thu");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;
                default:
                    Console.WriteLine("Invalid, enter a value between 1 and 7");
                    break;
            }

            /////For Loop//////
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hi");
            }

            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("What word do you want to repeat");
            string message = Console.ReadLine();

            Console.WriteLine("And how many times do you want to repeat that word?");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
            }

            ///While loops/////

            int i = 0;

            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }


            Console.WriteLine("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);


            Console.WriteLine("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.WriteLine("What's the value of " + numberA + " x " + numberB + "? ");
            Console.WriteLine();

            while (answer != actualAnswer)
            {
                Console.WriteLine("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong!. Try again.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Well done!");

            /////Do-While Loop/////
            Console.WriteLine("Enter the first number: ");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);


            Console.WriteLine("Enter the second number: ");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);
            Console.WriteLine();

            int answer = numberA * numberB;
            int actualAnswer = 0;

            Console.WriteLine("What's the value of " + numberA + " x " + numberB + "? ");
            Console.WriteLine();

            do
            {
                Console.WriteLine("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if (answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong!. Try again.");
                    Console.WriteLine();
                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");
        }
    }
}
