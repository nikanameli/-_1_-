int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void Nto1(int n)
{
    if (n <= 0)
    {
        return;
    }
    else 
    {   
        Console.Write(n + " ");
        Nto1(n - 1);
    }
}

int number  = ReadNumber("Введите число.");
Nto1(number);