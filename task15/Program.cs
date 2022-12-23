// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число для определения дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
Console.WriteLine("Да");
else 
if (number > 7)
    Console.WriteLine("Такого дня недели не существует, введите число от 1 до 7.");
else Console.WriteLine("Нет");