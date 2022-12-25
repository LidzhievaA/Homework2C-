Console.WriteLine("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number>100)
    {int number3 = number%10;
    number = number/10;
    if (number <100)
    {
Console.WriteLine(number3);
    }
}
}

