﻿// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да
// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numbersave = number;
// int rebnum = 0;
// while (number > 0)
// {
//     rebnum = rebnum * 10 + number % 10;
//     number = number / 10;
// }
// if (numbersave == rebnum) Console.WriteLine($"Число {numbersave} - палиндром");
// else Console.WriteLine($"Число {numbersave} - не палиндром");



// // Задача 21
// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53
// double PromptAndInput(string text)
// {
//     Console.Write("Введите " + text + ": ");
//     double result = Convert.ToDouble(Console.ReadLine());
//     return result;
// }
// Console.Clear();
// double[] point1 = {PromptAndInput("X1"), PromptAndInput("Y1"), PromptAndInput("Z1")};
// double[] point2 = {PromptAndInput("X2"), PromptAndInput("Y2"), PromptAndInput("Z2")};
// Console.WriteLine("Расстояние: " +
//     Math.Sqrt(
//         Math.Pow(point1[0]-point2[0],2)+
//         Math.Pow(point1[1]-point2[1],2)+
//         Math.Pow(point1[2]-point2[2],2)
//     )
// );



// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125
// Console.Clear();
// Console.Write("Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine());
// Console.Write(num + " -> " + 1);
// for (int i = 2; i<=num; i++)
//     Console.Write(", " + Math.Pow(i,3));