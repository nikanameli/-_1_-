int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
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
    Console.WriteLine("Введите номер строки элемента больше 0.");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбика элемента больше 0.");
    int numberB = Convert.ToInt32(Console.ReadLine());

    if (numberA > matrix.GetLength(0) || numberB > matrix.GetLength(1) || numberA < 1|| numberB < 1 )  
    {
        Console.WriteLine("В данном массиве нет элемента с такой позицией.");
    }
    else 
    {
        Console.WriteLine(matrix[numberA -1, numberB -1]);
    }
}


int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
result(matr);

