﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number>= 100 && number <=999)
{
    int number3 = number % 100;
    int number2 = number3 / 10;
    Console.WriteLine($"{number} => {number2}");
}
else
    Console.WriteLine("Вы ввели не трёхзначное число");

