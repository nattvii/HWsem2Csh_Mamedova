﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.Write("Введи трёхзначное число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(n2);
Console.WriteLine("Вторая цифра числа = "+ stringNumber[1]);
