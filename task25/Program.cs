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


int[,] GetMatrix1(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix1 = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix1;
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


void result(int[,] matrix, int[,] matrix1)
{   
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i, j] * matrix1[i, j];
        }
    }
    PrintMatrix(matrix);
}



int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
int[,] matr1 = GetMatrix1(m, n);
PrintMatrix(matr);
Console.WriteLine();
PrintMatrix(matr1);
Console.WriteLine();
result(matr, matr1);


