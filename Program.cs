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

// Console.Write("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// string num1 = num.ToString();

// if(num < 10000 || num > 99999){
//     Console.WriteLine("Ошибка!!! Это не пятизначное число");
// }
// else if(num1[0] == num1[4] && num1[1] == num1[3]){
//     Console.WriteLine($"{num} -> да");
// }
// else {
//     Console.WriteLine($"{num} -> нет");
// }


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

//                                           Урок 4 (Семинар 4)

//                                              Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Введите число A: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень числа B: ");
// int pow = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{num}, {pow} -> {GetNumInPow(num, pow)}");

// //-----Method-----
// int GetNumInPow(int number, int power){
//     int mult = 1;
//     for (int i = 0; i < power; i++)
//     {
//         mult = mult * number; 
//     }
//     return mult;
// }


//                                              Задача 27:
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. либо строки, либо математика

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{num} -> {GetSumDigits(num)} in Math");
// string num2 = num.ToString();
// Console.WriteLine($"{num2} -> {GetSumDigits2(num2)} in Str");

// //-----Method-----Math
// int GetSumDigits(int number)
// {
//     int sum = 0;
//     int result = 0;
//     while(number != 0){
//         result = number % 10;
//         sum += result; 
//         number = number /  10;
//     }
//     return sum;
// }

// //-----Method-----String
// int GetSumDigits2(string number){
//     int sum = 0;
//     int count =  number.Length;
//     int num = Convert.ToInt32(number);
//     for (int i = 0; i < count; i++)
//     {
//         int result = num % 10;
//         sum += result;
//         num = num / 10;
//     }
//     return sum;
// }

//                                              Задача 29: 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

// int[] arr = GetArray(8);
// Console.WriteLine($"[{String.Join(',', arr)}]");

// //-----Method-----
// int[] GetArray(int size){
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(10, 100);
//     }
//     return arr;
// }

//=================================================================================================================================

//                                          Урок 5 (Семинар 5)

//                                              Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] array = GetArray(4, 100, 1000);
// Console.Write($"[{String.Join(",", array)}]");
// Console.WriteLine($" -> {EvenNumberCount(array)}");
// //-----Метод подсчета количества чётных чисел в массиве-----
// int EvenNumberCount(int[] array){
//     int count = 0;
//     foreach (int el in array)
//     {
//         if(el % 2 == 0) count++;
//     }
//     return count;
// }
// //-----Method-----
// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }


//                                               Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// int[] array = GetArray(4, -100, 100);
// Console.Write($"[{String.Join(",", array)}]");
// Console.WriteLine($" -> {OddIndexSum(array)}");
// //-----Метод нахождения суммы элементов нечетных индексов-----
// int OddIndexSum(int[] arr){
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(i % 2 != 0) sum += arr[i];
//     }
//     return sum;
// }
// //-----Method-----
// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }


//                                                  Задача 37: 
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// int[] array = GetArray(5, 1, 10);
// Console.Write($"[{String.Join(",", array)}] -> ");
// PairNumMultiplay(array);
// //-----Метод: произведение пар чисел-----
// int PairNumMultiplay(int[] arr){
//     int mult = 1;
//     int len = arr.Length;
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         mult = arr[i] * arr[arr.Length - i - 1];
//         Console.Write($"{mult} ");
//     }
//     if(len % 2 != 0)
//     Console.Write($"{arr[arr.Length / 2]}");
//     return 0;
// }
// //-----Method-----
// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue);
//     }
//     return res;
// }

//=================================================================================================================================

//                                          Урок 6 (Семинар 6)

//                                              Задача 41: 
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// Console.Write("Введите массив любых чисел (через пробел): ");
// int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0) count++;
// }
// Console.WriteLine($"Количество чисел > 0: {count}");


//                                              Задача 43: 
//Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
//а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

// int[] array = GetArray(6, 0, 100);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine($"[{String.Join(",", SelectionSort(array))}]");

// //-----Methods-----
// int[] GetArray(int size, int minValue, int maxValue){
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// } 
// int[] SelectionSort(int[] array){
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int min = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[min]) min = j;
//         }
//     int temp = array[i];
//     array[i] = array[min];
//     array[min] = temp;
//     }
//     return array;
// }


//=================================================================================================================================

//                                          Урок 7 (Семинар 7)

//                                             Задача 47:
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m=3, n=4.

// double[,] array = GetArray(3, 4, -10, 10);
// PrintArray(array);

// //-----Methods-----
// double[,] GetArray(int m, int n, int minValue, int maxValue){
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
//         }
//     }
//     return result;
// }   
// void PrintArray(double[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }

//                                              Задача 50: 
// Напишите программу, которая на вход принимает число, проверяя есть ли такое число в двумерном массиве 
// и возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(3, 4, 1, 10);
// PrintArray(array);
// if(FindNumber(array, num)) Console.WriteLine($"{num} => такое число в массиве есть!");
// else Console.WriteLine($"{num} => такого числа в массиве нет");

// //-----Methods-----
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// bool FindNumber(int[,] array, int number){
//     bool isPresent = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(array[i, j] == number){
//                 isPresent = true;
//             }
//         }
//     }
//     return isPresent;
// }

//                                               Задача 52:
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] array = GetArray(3, 3, 1, 10);
// PrintArray(array);
// Average(array);
// //-----Methods-----
// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]}   ");
//         }
//         Console.WriteLine();
//     }
// }
// void Average(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         double result = Convert.ToDouble(sum);
//         double count = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[j, i];
//             count++;
//         }
//         Console.Write($"{(sum / count):f1} ");
//     }
// }


//=================================================================================================================================

//                                          Урок 8 (Семинар 8)

//                                              Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] myArray = GetArray(3,4);
// PrintArray(myArray);
// Console.WriteLine();
// SortToMinValue(myArray);
// PrintArray(myArray);
// //---------------Methods---------------
// int[,] GetArray(int m, int n){
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void SortToMinValue(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int l = 0; l < array.GetLength(1); l++)
//         {
//             for (int k = 0; k < array.GetLength(1)-1; k++)
//             {
//                 if(array[i, k] < array[i, k+1]){
//                     int temp = array[i, k+1];
//                     array[i, k+1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }


//                                              Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] myArray = GetArray(3, 4);
// PrintArray(myArray);
// GetSumRow(myArray);
// //---------------Methods---------------
// int[,] GetArray(int m, int n){
//     int[,] myArray = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             myArray[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return myArray;
// }
// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
//  void GetSumRow(int[,] array){
//     int sum = 0;
//     int minSum = 0;
//     int row = 0;
//     int rowMinSum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         row++;
//         sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if(row == 1){
//             minSum = sum;
//             rowMinSum = row;
//         } 
//         else if(sum < minSum){
//             minSum = sum;
//             rowMinSum = row;  
//         }
//     }
//     Console.Write($"Минимальная сумма {minSum} в {rowMinSum} ряду");
//  }
    

//                                              Задача 58: 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] matrix1 = GetMatrix(2, 2);
// int[,] matrix2 = GetMatrix(2, 2);
// int[,] resultMatrix = GetMatrix(2,2);
// PrintMatrix(matrix1);
// Console.WriteLine($"---");
// PrintMatrix(matrix2);
// MultiplyMatrixes(matrix1, matrix2, resultMatrix);
// Console.WriteLine("Результат умножения: ");
// PrintMatrix(resultMatrix);
// //---------------Methods---------------
// int[,] GetMatrix(int m, int n){
//     int[,] matrix = new int[m, n]
// ;    for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] MultiplyMatrixes(int[,] matrix1, int[,] matrix2, int[,] resultMatrix){
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 sum += matrix1[i, k] * matrix2[k, j];
//             }
//             resultMatrix[i, j] = sum;
//         }
//     }
//     return resultMatrix;
// }


//=================================================================================================================================
//                                          Урок 9 (Семинар 9)

//                                   Все задачи выполнить с помощью рекурсии

//                                              Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(GetNumbers(1, N));
// //---------------Method---------------
// string GetNumbers(int start, int end){
//     if(end == start) return end.ToString();
//     return (end + " " + GetNumbers(start, end - 1));
// }


//                                              Задача 66: 
// Задайте значение M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int M = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine(GetSum(M, N));
// //---------------Method---------------
// int GetSum(int start, int end){
//     if(start == end) return start;
//     return (start + GetSum(start + 1, end));
// }


//                                              Задача 68: 
// Напишите программу вычисления функции Аккермана. Даны два неотрицательных числа m и n.

// Console.Write("Введите число m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число n: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(FunctionAkkerman(m, n));
// //---------------Method---------------
// int FunctionAkkerman(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return FunctionAkkerman(m - 1, 1);
//   else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
// }