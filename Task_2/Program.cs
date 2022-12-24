// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumOfDigits (int a)
{
    int sum = 0;
    while(a > 1) 
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}

int a = EnterData("Введите число: ");
int result = SumOfDigits(a);
Console.WriteLine($"Сумма цифр в числе {a} = {result}");