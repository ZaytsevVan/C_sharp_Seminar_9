// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int m, int n)
{
    if(m == 0) 
    {
        return n + 1;
    }
    else
    {
        if(m != 0 && n == 0) 
        {
            return (A(m - 1, 1));
        }
        else
        {
            return A(m - 1, A(m, n - 1));
        }
    }
    
    
}

void Main()
{
    int m = ReadInt("Введите первое число: ");
    int n = ReadInt("Введите второе число: ");
    if(m < 0 || n < 0) 
    {
        Console.WriteLine("Вы указали неверное число, введите два неотрицательных целых числа");
    }
    int number = A(m, n);
    Console.WriteLine(number);
}

Main();