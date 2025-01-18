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
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);

            //Console.Write() Does not push everything after to the next line.
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            Console.WriteLine("Your name is " + name + " and your age is " + age);
        }
    }
}
