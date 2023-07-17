// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfNumber(int a, int b)
{
    if(a == b) return a;
    return a + SumOfNumber(a + 1, b);
}

void Main()
{
    int m = ReadInt("Введите первое число: ");
    int n = ReadInt("Введите второе число: ");
    int sum = 0;
    if(m > n) 
    {
        sum = SumOfNumber(n, m);
    }
    else
    {
        sum = SumOfNumber(m, n);
    }
    Console.WriteLine(sum);
}

Main();
