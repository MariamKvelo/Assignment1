// N1 (prints full name)

/*Console.Write("Enter your given name: ");

string givenName = Console.ReadLine();

Console.Write("Enter your last name: ");

string lastName = Console.ReadLine();


Console.WriteLine("Your full name is: " + givenName +" " + lastName);*/




// N2 (prints sum/sub/mult/div)

/*using System;

double number1;
double number2;

Console.Write("Enter Number 1: ");

number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Number 2: ");

number2 = Convert.ToDouble(Console.ReadLine());

double sum = number1 + number2;
double sub = number1 - number2;
double mult = number1 * number2;
double div = number1 % number2;

Console.WriteLine(sum);
Console.WriteLine(sub);
Console.WriteLine(mult);
Console.WriteLine(div);*/



// N3 (swaps values)

/*double x;
double y;

Console.Write("x: ");

x = Convert.ToDouble(Console.ReadLine());

Console.Write("y: ");

y = Convert.ToDouble(Console.ReadLine());

double tempswap = x;
x = y;
y = tempswap;

Console.WriteLine("x=" + x + " " + "and " + "y=" + y);*/



// N4 (calculates average value)

/*double num1;
double num2;
double num3;
double num4;

Console.Write("Enter a number: ");

num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter a number: ");

num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter a number: ");

num3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter a number: ");

num4 = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2 + num3 + num4;
double average = sum / 4;

Console.WriteLine("The average velue is: " + average);*/



// N5 (converts kelvin to celsius)

/*double kelv;

Console.Write("Kelvin = ");

kelv = Convert.ToDouble(Console.ReadLine());

double cels;

cels = kelv - 273.15;

Console.WriteLine("This equals to " + cels + " " + "degree Celsius");*/



// N6 (if a number is positive it prints "true")

/*using System;

double number;

Console.Write("Enter number: ");

number = Convert.ToDouble(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("your number is positive");
}

else {
    Console.WriteLine("Please try again");
}*/



// N7 (prints greatest and smallest numbers)

/*using System.Security.Cryptography.X509Certificates;

double num1;
double num2;
double num3;

Console.WriteLine();

num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

num3 = Convert.ToDouble(Console.ReadLine());

if (num1 >= num2 && num2 > num3)
{
    Console.WriteLine("the greatest number is: " + num1 + " " + "the smallest number is " + num3);
}


if (num1 >= num3 && num3 > num2)
{
    Console.WriteLine("the greatest number is: " + num1 + " " + "the smallest number is " + num2);
}


if (num2 >= num3 && num3 > num1)
{
    Console.WriteLine("the greatest number is: " + num2 + " " + "the smallest number is " + num1);
}


if (num2 >= num1 && num1 > num3)
{
    Console.WriteLine("the greatest number is: " + num2 + " " + "the smallest number is " + num3);
}


if (num3 >= num1 && num1 > num2)
{
    Console.WriteLine("the greatest number is: " + num3 + " " + "the smallest number is " + num2);
}


if (num3 >= num2 && num2 > num1)
{
    Console.WriteLine("the greatest number is: " + num3 + " " + "the smallest number is " + num1);
}

if (num1 == num2 && num2 == num3)
{
    Console.WriteLine("the greatest number is: " + num1 + " " + "the smallest number is " + num1);
}*/



// N8 (if numbers are equal multiplies 3 times)

/*using System.Globalization;

double x;
double y;

Console.Write("Enter the value for x: ");

x = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the value for y: ");

y = Convert.ToDouble(Console.ReadLine());

if (x == y)
{
    Console.WriteLine(x*=3);
}
else
{
    Console.WriteLine("Numbers are not equal");
}*/


// N9 (checks multiples of 7)

/*using System.Globalization;

double x;

Console.Write("Enter number: ");
x = Convert.ToDouble(Console.ReadLine());

if (x % 7 == 0)
{

    Console.WriteLine("The number is multiple of seven");
}

else
{
    Console.WriteLine("The number is not multiple of seven");
}*/


// N10 (prints whether the value contains number 5)

/*double num;

Console.Write("Enter number: ");
num = Convert.ToDouble(Console.ReadLine());

if (num % 5 == 0 && num % 10 != 0)
{
    Console.WriteLine("Your value contains number 5");
}

else
{
    Console.WriteLine("Your number does not contain number 5");
}*/
