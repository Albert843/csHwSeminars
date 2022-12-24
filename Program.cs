//================================================================================================================

//                              Урок 1. Знакомство с языком программирования С#

//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
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
*/

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

//=========================================================================================================================

//                                              Урок 2.

//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//          Обязательна проверка на ввод чисел больше/меньше 3-х знаков
/*
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
if((number < 100) || (number >= 1000)) 
{
    Console.Write("Введено некорректное число!!!");
}
else
{
    Console.Write($"{number} -> {(number/10)%10}");
}
*/

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//          Берем числа до 100000
/*
Console.Write("Введите число от 100 до 100000: ");
int number = int.Parse(Console.ReadLine()!);
int digitNumber = number;
if(number < 100) {
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else if(number >= 100000) {
    Console.WriteLine($"{number} -> Введено число больше чем 100000 включительно!!!");
}
else{
    int counter = 1;
    while((digitNumber/10) !=0) {          // в цикле "while" определяется разрядность числа, введенного пользователем
        digitNumber = digitNumber/10;
        counter++;
    }
    Console.WriteLine(counter);     
    if(counter == 3) {                                            // если число 3-разрядное 
        Console.WriteLine($"{number} -> {number%10}");
    }
    if(counter == 4) {                                           // если число 4-разрядное
        Console.WriteLine($"{number} -> {(number/10)%10}");
    }
    if(counter == 5) {                                           // если число 5-разрядное
        Console.WriteLine($"{number} -> {(number/100)%10}");
    }
}
*/

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. 
//          Обязательна проверка на ввод числа <1 и >7

// Console.Write("Введите число от 1 до 7 включительно: ");
// int number = int.Parse(Console.ReadLine()!);
// if((number < 1) || (number > 7))
// {
//     Console.WriteLine("Введено некорректное число");
// }   
// else if((number == 6) || (number == 7))
// {
//     Console.WriteLine($"{number} -> да");
// } 
// else
// {
//     Console.WriteLine($"{number} -> нет");
// }  

//=====================================================================================================================================

//                                              Урок 3.

//                                             Задача 1:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Проверка на пятизначность обязательна.

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
string num1 = num.ToString();

if(num < 10000 || num > 99999){
    Console.WriteLine("Ошибка!!! Это не пятизначное число");
}
else if(num1[0] == num1[4] && num1[1] == num1[3]){
    Console.WriteLine($"{num} -> да");
}
else {
    Console.WriteLine($"{num} -> нет");
}


//                                              Задача 2:
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("Введите координату X точки A: ");
// int xa = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Y точки A: ");        //Координаты первой точки
// int ya = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Z точки A: ");
// int za = int.Parse(Console.ReadLine()!);

// Console.Write("Введите координату X точки B: ");
// int xb = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Y точки B: ");        //Координаты второй точки
// int yb = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координату Z точки B: ");
// int zb = int.Parse(Console.ReadLine()!);

// double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
// Console.WriteLine($"Расстояние между точками = {result:f2}");


//                                              Задача 3:
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// for(int i = 1; i <= N; i++){
//     Console.Write($"{Math.Pow(i, 3)} ");
// }

//=================================================================================================================================





