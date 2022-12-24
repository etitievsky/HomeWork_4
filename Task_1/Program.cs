// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B (без использования Math.Pow)

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int MathPow (int a, int b)
{
    int pow = a;
    for(int i=1; i<b; i++)
    {
        pow = pow * a;
    }
return pow;
}


int a = EnterData("Введите число А: ");
int b = EnterData("Введите число B: ");
int result = MathPow(a, b);
Console.WriteLine($"Число {a} в степени {b} = {result}");