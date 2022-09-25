int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void result(int[,] matrix)
{   
    int min = 0;
    int minI = 0; 
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int summStr = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            summStr += matrix[i,j]; 
        }
        if (i == 0)
        {
            min = summStr;
            minI = i;
        }
        else if(summStr < min)
        {
            min = summStr;
            minI = i;
        }
    }
    Console.WriteLine($"Строчка с минимальной суммой элементов - { minI+1 }");
}


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
result(matr);
