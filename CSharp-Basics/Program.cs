using System.Buffers.Text;
using System.Collections.Concurrent;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace CSharp_Basics
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
/////////////////////////////////////////////////////////////
/////////Week 2, Lecture 1: C# Fundamentals//////////////////
/////////////////////////////////////////////////////////////

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

//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();

//Console.WriteLine("Enter your age: ");
//string ageInput = Console.ReadLine();
//int age = Convert.ToInt32(ageInput);

//Console.WriteLine("Your name is " + name + " and your age is " + age);

////==, >, >=, <, <=, !=, ||, &&


//  if (age >= 18 && age <= 25)
//{
//    Console.WriteLine("You are between 18 and 25");
//}
//else if (age >= 26)
//{
//    Console.WriteLine("You are 26 or older");
//}



//if (age < 0 || age > 150)
//{
//    Console.WriteLine("Invalid age!");
//}
//else
//{
//    if (age >= 18 && age <= 25)
//    {
//        Console.WriteLine("You are between 18 and 25");
//    }
//    else if (age >= 26)
//    {
//        Console.WriteLine("You are 26 or older");
//    }
//}

//Console.WriteLine("Enter the first number: ");
//string numberAInput = Console.ReadLine();
//int numberA = Convert.ToInt32(numberAInput);


//Console.WriteLine("Enter the second number: ");
//string numberBInput = Console.ReadLine();
//int numberB = Convert.ToInt32(numberBInput);

//int answer = numberA * numberB;

//Console.WriteLine("Value of " + numberA + " x " + numberB + ": ");
//string answerInput = Console.ReadLine();
//int actualAnswer = Convert.ToInt32(answerInput);

//if (answer == actualAnswer)
//{
//    Console.WriteLine("Well done!");
//}
//else
//{
//    Console.WriteLine("Close but it was wrong!");
//}

/////Switch Statements/////
//Console.WriteLine("Enter a day of the week: ");
//int day = Convert.ToInt32(Console.ReadLine());

//switch (day)
//{
//    case 1:
//        Console.WriteLine("Mon");
//        break;
//    case 2:
//        Console.WriteLine("Tue");
//        break;
//    case 3:
//        Console.WriteLine("Wed");
//        break;
//    case 4:
//        Console.WriteLine("Thu");
//        break;
//    case 5:
//        Console.WriteLine("Fri");
//        break;
//    case 6:
//        Console.WriteLine("Sat");
//        break;
//    case 7:
//        Console.WriteLine("Sun");
//        break;
//    default:
//        Console.WriteLine("Invalid, enter a value between 1 and 7");
//        break;
//}

///////For Loop//////
//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Hi");
//}

//for (int i = 0; i <= 10; i += 2)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("What word do you want to repeat");
//string message = Console.ReadLine();

//Console.WriteLine("And how many times do you want to repeat that word?");
//int loopCounter = Convert.ToInt32(Console.ReadLine());

//if (loopCounter <= 0)
//{
//    Console.WriteLine("Sorry, please enter a value above 0");
//}
//else
//{
//    for (int i = 0; i < loopCounter; i++)
//    {
//        Console.WriteLine(message);
//    }
//}

/////While loops/////

//int i = 0;

//while (i < 10)
//{
//    i++;
//    Console.WriteLine(i);
//}

//int i = 0;

//while (i < 10)
//{
//    Console.WriteLine(i);
//    i++;
//}


//Console.WriteLine("Enter the first number: ");
//string numberAInput = Console.ReadLine();
//int numberA = Convert.ToInt32(numberAInput);


//Console.WriteLine("Enter the second number: ");
//string numberBInput = Console.ReadLine();
//int numberB = Convert.ToInt32(numberBInput);
//Console.WriteLine();

//int answer = numberA * numberB;
//int actualAnswer = 0;

//Console.WriteLine("What's the value of " + numberA + " x " + numberB + "? ");
//Console.WriteLine();

//while (answer != actualAnswer)
//{
//    Console.WriteLine("Enter your answer: ");
//    string answerInput = Console.ReadLine();
//    actualAnswer = Convert.ToInt32(answerInput);

//    if (answer != actualAnswer)
//    {
//        Console.WriteLine("Close but it was wrong!. Try again.");
//        Console.WriteLine();
//    }
//}

//Console.WriteLine("Well done!");

///////Do-While Loop/////
//Console.WriteLine("Enter the first number: ");
//string numberAInput = Console.ReadLine();
//int numberA = Convert.ToInt32(numberAInput);


//Console.WriteLine("Enter the second number: ");
//string numberBInput = Console.ReadLine();
//int numberB = Convert.ToInt32(numberBInput);
//Console.WriteLine();

//int answer = numberA * numberB;
//int actualAnswer = 0;

//Console.WriteLine("What's the value of " + numberA + " x " + numberB + "? ");
//Console.WriteLine();

//do
//{
//    Console.WriteLine("Enter your answer: ");
//    string answerInput = Console.ReadLine();
//    actualAnswer = Convert.ToInt32(answerInput);

//    if (answer != actualAnswer)
//    {
//        Console.WriteLine("Close but it was wrong!. Try again.");
//        Console.WriteLine();
//    }
//} while (answer != actualAnswer);

//Console.WriteLine("Well done!");

/////Common Escape Sequences/////
//\n - New Line
//\t - Horizontal Tab
//\\ -Backslash
//\" - Quotation

//string code = "JSPS";
//double price = 49.50;
//string result = "Code: " + code + "\n" + "Price: $" + price;
//Console.WriteLine(result);
//Console.WriteLine("c:\\c#.net\\files");
//Console.WriteLine("Type \"x\" to exit");

/////Verbatim String Literals/////
//string str = @"hello \n world";
//string path = @"c:\c#.net\files";
//string msg = @"Type ""x"" to exit";
//Console.WriteLine(str);
//Console.WriteLine(path);
//Console.WriteLine(msg);

/////More String interpolation/////
//string firstname = "John";
//string lastname = "Smith";
//string fullname = $"{firstname,10} {lastname,-10}";

//Console.WriteLine(fullname);

/////Value Types and Reference Types/////
//Circle c1, c2;
//c1 = new Circle();
//c1.radius = 30; // radius is a field defined in Circle class
//c2 = c1;
//Console.WriteLine(c2.radius);
//c2.radius = 50;
//Console.WriteLine(c1.radius);

/////Predefined Reference Types/////
//The object type
//The string type -> System.String. 

//Although the string type is a referece data type, it differs in behavior is some
//aspects from other reference types.
//In general, the stringclass has been implemented so that its semantics follow
//what you would normally intuitively expect for a string.

/////Type Conversions/////
//Implicit Type Conversion - these conversions are performed by C# in a type-safe manner. 
//Examples are conversions from smaller to larger integral types.

//int i = 10;
//double d = i; //int implicitly converts to double
//string s = "i = " + i; //int implicitly converts to string

//Explicit Type Conversion - these conversions are done explicitly by users using the pre-defined functions.
//Explicit conversions require a cast operator.

//double d = 10.5;
//int i = (int)d;
//Console.WriteLine(i);

/////Type conversion methods/////
//string s = "10";
//int i = Convert.ToInt32(s); //Convert string to int
//s = i.ToString(); //Convert int to string

////ToString() Method to Format a Number/////

//"C": Currency Format
//"C" formats the number as currency using the system's current culture settings.
//It adds the appropriate currency symbol($, €, etc.) based on your computer's locale 
//and applies formatting (e.g., commas for thousands and two decimal places).
//decimal amount = 1547.2M;
//Console.WriteLine(amount.ToString("C")); //Output: $1,547.20

//"P1": Percentage Format
//"P1" formats the number as a percentage by multiplying it by 100 and appending a % sign.
//The 1 indicates the number of decimal places to display.
//decimal interest = 0.023M;
//Console.WriteLine(interest.ToString("P1")); //Output: 2.3%

//"N0": Number Format
//"N0" formats the number as a numeric value with a thousands separator but no decimal places.
//The 0 means 0 decimal places.
//int quantity = 15000;
//Console.WriteLine(quantity.ToString("N0")); //Output: 15,000

//"F3": Fixed - Point Format
//"F3" formats the number in a fixed-point representation with 3 decimal places.
//The 3 indicates the number of decimal places to display.
//double payment = 432.8175;
//Console.WriteLine(payment.ToString("F3")); //Output: 432.818


/////nullable data type/////
//int? quantity
//quantity = null;
//quantity = 0;
//quantity = 20;

//decimal? salesTotal = null;

//bool? isValid = null;


//        }
//    }
//}

/////////////////////////////////////////////////////////////
/////////Week 2, Lecture 2: Methods and Enums////////////////
/////////////////////////////////////////////////////////////

/////Methods/////
/*
- Functions: A broad term that includes all non-data members of a class or 
struct that perform actions (methods, properties, constructors, etc.).
- Methods: A specific type of function used to perform an action or return a value.
A method is a group of statements that together perform a task.
Every C# program has at least one class with a method named Main.
To use a method, you need to:
    Define the method
    Call the method
- Data Members: Store data and do not perform actions (fields, constants, and events).
*/

//Method without parameters and without return type:
//public void Add()
//{
//    int a = 10;
//    int b = 20;

//    int sum = a + b;

//    Console.WriteLine("Sum is " + sum);
//}

//Method with parameters and without return type:
//public void Add(int x, int y)
//{
//    int sum = x + y;
//    Console.WriteLine("Sum is " + sum);
//}

//Method without parameters and with return type:
//public int Add()
//{
//    int x = 10;
//    int y = 20;
//    int sum = x + y;

//    return sum;
//}

//Method with parameters and with return type
//public int Add(int x, int y)
//{
//    int sum = x + y;
//    return sum;
//}

/////Method Parameters/////
//Value Parameters
//Reference Parameters
//Output Parameters
//Parameter Array

//Example of Passing By Value and Reference    
//namespace CSharp_Basics
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int i = 0;
//            string s = "hello";
//            int[] a = { 0, 1, 2, 4, 8 };

//            Console.WriteLine("Before Changes: ");
//            Console.WriteLine("i = " + i);
//            Console.WriteLine("s = " + s);
//            Console.WriteLine("a[0] = " + a[0]);

//            ChangeValues(i, s, a);
//            Console.WriteLine("\nAfter Changes:");
//            Console.WriteLine("i = " + i);
//            Console.WriteLine("s = " + s);
//            Console.WriteLine("a[0] = " + a[0]);
//        }

//        static void ChangeValues(int num, string str, int[] array)
//        {
//            num = 100;
//            str = "bye";
//            array[0] = 100;
//        }

//    }

//}

//Example of Passing Parameters by Value
//namespace CSharp_Basics
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 10, b = 20;

//            Console.WriteLine("Before swapping:");
//            Console.WriteLine("a: " + a);
//            Console.WriteLine("b: " + b);
//        }

//        static void Swap(int x, int y)
//        {
//            int temp = x;
//            x = y;
//            y = temp;
//        }

//        //Output:
//        //Before swapping:
//        //a: 10
//        //b: 20
//        //After swapping:
//        //a: 10
//        //b: 20

//    }

//}

//Example of Passing Parameters by Reference
//namespace CSharp_Basics
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 10, b = 20;

//            Console.WriteLine("Before swapping:");
//            Console.WriteLine("a: " + a);
//            Console.WriteLine("b: " + b);

//            Swap(ref a, ref b);

//            Console.WriteLine("\nAfter swapping:");
//            Console.WriteLine("a: " + a);
//            Console.WriteLine("b: " + b);
//        }

//        static void Swap(ref int x, ref int y)
//        {
//            int temp = x;
//            x = y;
//            y = temp;
//        }

//        //Output:
//        //Before swapping:
//        //a: 10
//        //b: 20
//        //After swapping:
//        //a: 20
//        //b: 10

//    }

//}

/////Output Parameters/////
//namespace CSharp_Basics
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 10, b = 20, sum, mul; //sum and mul arent initialized
//        }

//        static void Calculate(int a, int b, out int sum, out int mul)
//        {
//            sum = a + b;
//            mul = a * b;
//        }

//        //Output:
//        //Sum = 30
//        //Mul = 200

//    }

//}

/////Parameter Arrays/////
//namespace CSharp_Basics
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 101, 102, 103 };

//            PrintArray(numbers); //Passing arguments as an array to PrintArray method (Parameter Array).
//            PrintArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9); //Passing arguments as a comma separated list to PrintArray method
//        }

//        static void PrintArray(params int[] num)
//        {
//            Console.WriteLine("Number of elements: " + num.Length);

//            foreach (int i in num)
//                Console.Write(i + " ");
//        }

//        //Output:
//        //Number of elements: 3
//        //101 102 103

//        //Number of elements: 10
//        //0 1 2 3 4 5 6 7 8 9

//    }

//}

/////Named Arguments/////
//Simple method definition

//    static string PersonInfo(string name, int age) {
//        Console.WriteLine("Name = " + name);
//        Console.WriteLine("Age = " + age);
//    }

////Calling the method without any named arguments (like we did so far)
//PersonInfo("John", 34);

////Calling the method with named arguments
//PersonInfo(age: 34, name: "John");


/////Optional Arguments/////
//Arguments can also be optional.
//While defining the method, supply a default valuefor optional parameters,
//which must be the last ones defined.


//Different ways to call a method with optional arguments

//static void PersonInfo(string name = "John", int age = 21) {
//    Console.WriteLine("Name = " + name);
//    Console.WriteLine("Age = " + age);
//}

//1. Omit the optional parameters
//PersonInfo();

//2. Omit second optional parameter
//PersonInfo("Mark");

//3. You CAN'T omit the first but keep the second
//PersonInfo(37); //Not Allowed

//4. Classic calling syntax
//PersonInfo("Mark", 37);

//5. Specify one named parameter
//PersonInfo(age: 37);

//6. Specify both named parameter
//PersonInfo(age: 37, name: "Mark");


/////Expression-Bodied Methods/////

//Regular methods
//public double FindSquare(double num) {
//    return num * num;
//}

//Expression-Bodied Method
//public double FindSquare(double num) => num * num; 

/////Enumeration in C# (Enums)/////


 //Defining an Enum
    public enum Color {
        Red,  // 0
        Green,  // 1 
        Blue  // 2
    }
/*
 *By default, the first member gets the value 0, the second gets 1, and so on 
 */

//Using an enum

/*
* You create a variable of that enum type and assign it one of the named constants
*/

Color c = Color.Red;
Console.WriteLine(c); //Output: Red

// Why use enums?
/*They make your code easier to read and maintain. 
Instead of using raw numbers, you use meaningful names like Red, Green, Blue.

Enums are perfect for scenarios where you have a fixed set of values—like days of the week, 
months, card suits, etc.—because these values don’t change over time.
*/

// Enums behind the scenes
/*
An enum is actually backed by an integer type (by default, int);
If you need a different size (like byte, short, or long), you can specify it:
*/

public enum Day : short {
    Sunday, 
    Monday, 
    Tuesday,
    Wednesday, 
    Thursday, 
    Friday, 
    Saturday
}

/*
* Even when using different underlying types, the concept stays the same.
*/

// Getting the numeric value
/*
* If you want to see the integer behind, for example, Day.Sunday, you do a cast:
*/

Console.WriteLine((int)Day.Sunday); // prints the number 0 (or a custom value if changed)

//Custom integer values
/*
* You don’t have to stick to 0, 1, 2... You can assign your own numbers to each enum member:
*/

enum Day
{
    Sunday = 10,
    Monday = 2,
    Tuesday = 8,
    // etc.
}

/*
* If you give the first member a number (e.g., Sunday = 10) but leave the rest unassigned, 
  they automatically follow on from there (Monday = 11, Tuesday = 12, and so on).
* Or you can assign random values anywhere. C# doesn’t enforce a sequence.
*/

