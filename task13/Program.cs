// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number>99)
    {int number3 = number%10;
    number = number/10;
    if (number <100)
    {
Console.WriteLine(number3);
    }
}
}

