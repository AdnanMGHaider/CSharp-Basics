namespace CSharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, My name is Adnan Haider.");

            Console.ReadLine();

            /////Numeric Data Types/////

            Console.WriteLine("int");
            int age;
            int age2 = 23;
            int age3 = -23;
            Console.WriteLine($"Age1: {age2}, Age2: {age3}");
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            Console.WriteLine("Long");
            long bigNumber = 900000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            Console.WriteLine("Float");
            float precision = 5.000001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            Console.WriteLine("Double");
            double negative = -55.2;
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            //Highest precision, suitable for financial and monetary calculation.
            Console.WriteLine("Decimal");
            decimal money = 14.99M;
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            /////Declaring Variables/////

            int x = 20;
            int y = 30;
            int z = 40;

            int x = 90, y = 80, z = 70;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            y = 115;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


            /////Strings and Characters/////
            //You cannot use single quotations for string type
            string name = "Aba";
            char letter = 'a';
            Console.WriteLine(name);
            Console.WriteLine(letter);

            string myName = "My name is Adnan. ";
            string myAge = "I'm 33 years old";
            Console.Write(myName);
            Console.Write(myAge);

            string emptyString = "";

            /////Converting string to int/////
            string stringInt = "-23";
            int convertedStringToInt = Convert.ToInt32(stringInt);
            Console.WriteLine(convertedStringToInt);

            /////Converting string to other numeric data types/////
            string stringBigNumber = "90000000"; //No need to put L in this case.
            long convertedStringToLong = Convert.ToInt64(stringBigNumber);
            Console.WriteLine(convertedStringToLong);

            string stringDouble = "55.2";
            double convertedStringToDouble = Convert.ToDouble(stringDouble);
            Console.WriteLine(convertedStringToDouble);

            string stringFloat = "45.2";
            double convertedStringToFloat = Convert.ToSingle(stringFloat);
            Console.WriteLine(convertedStringToFloat);

            string stringDecimal = "7.29";
            decimal convertedStringToDecimal = Convert.ToDecimal(stringDecimal);
            Console.WriteLine(convertedStringToDecimal);

            /////Boolean Data Type/////
            bool value = true;

            bool isMale = true;

            Console.WriteLine(isMale);

            /////Operators/////
            int age = 33;
            age++;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            age = age + 5;
            Console.WriteLine(age);
            age += 1;
            Console.WriteLine(age);

            //age++, age = age + 1, and age += 1 all do the same thing


            age -= 1;
            age *= 5;
            age /= 7;

            int i = 5;
            int result1 = i++;
            Console.WriteLine(result1); // Prints 5 and then increases the value from 5 to 6 internally
            int result2 = ++i;
            Console.WriteLine(result2); // 6 becomes 7 internally, and then 7 gets printed


            int randomNumber = 9;
            randomNumber /= 2;
            Console.WriteLine(randomNumber); //The result is 4, and .5 is truncated.

            double randomNumber2 = 7;
            randomNumber2 /= 2;
            Console.WriteLine(randomNumber2); //Now the result is not truncated to remove numbers after decimal

            ///String Concatenation/////
            string name = "Adnan";
            name += " is a Computer Programmer";
            Console.WriteLine(name);


        }
    }
}
