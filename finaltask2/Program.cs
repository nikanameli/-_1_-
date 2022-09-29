int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MtoN(int m, int n, int summ)
{
    if (n < m)
    {
        return summ;
    }
    else
    {   
        return MtoN(m + 1, n, summ + m);  
    }
}

int M  = ReadNumber("Введите M.");
int N  = ReadNumber("Введите N.");
Console.WriteLine(MtoN(M, N, 0));