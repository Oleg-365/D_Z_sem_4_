//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Main();

void Main()
{
    int number = Promt();
    int len = NumberLen(number);
    Validate(number);
    Sum(number, len);
    Console.Write($"Сумма цифр числа {number} составляет {Sum(number, len)}.");
}

int Promt()
{
    Console.Write("Введите число не меньше 11: ");
    int Num = int.Parse(Console.ReadLine()!);
    return Num;
}

int Validate(int Num)
{
    if (Num >= 11)
    {
        return Num;
    }
    else
    {
        Console.Write("Вы ввели неверное число! Введите число не меньше 11! ");
    }
    return Num;
}

int NumberLen(int Num)
{
    int index = 0;
    while (Num > 0)
    {
        Num /= 10;
        index++;
    }
    return index;
}

int Sum(int Num, int length)
{
    int Summa = 0;
    for (int index = 0; index < length; index++)
    {
        Summa += Num % 10;
        Num /= 10;
    }
    return Summa;
}

