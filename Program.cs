//                              Урок 1. Знакомство с языком программирования С#

//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine()!);
int max = 0;
if(num1 > num2)
{
    max = num1;
}
else max = num2;
Console.WriteLine($"max: {max}");


//  Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Enter first number: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter third number: ");
int num3 = int.Parse(Console.ReadLine()!);
int max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
Console.WriteLine($"max: {max}");
*/

//  Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
if(number % 2 == 0) Console.WriteLine($"{number} - even");
else Console.WriteLine($"{number} - odd");
*/

//  Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
int startNum = 1;
while(startNum <= number)
{
    if(startNum % 2 == 0) Console.Write($"{startNum} ");
    startNum++;
}
*/


