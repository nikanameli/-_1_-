int func(int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if (n == 0) 
    {
        return func(m - 1, 1);
    }
    else 
    {
        return func(m - 1, func(m, n - 1));
    }
}
Console.WriteLine("Введите 2 числа.");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(func(m, n));

// Иван, спасибо Вам!
// Удачи в карьере!)