﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число дня недели: ");
int dayN = Convert.ToInt32(Console.ReadLine());
if (dayN == 6 || dayN == 7) 
    Console.WriteLine("Этот день выходной");
else 
    Console.WriteLine("Этот день не выходной");
  