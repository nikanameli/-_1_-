int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GetMatrix(int rowsCount, int columnsCount, int lineCount, int leftRange = 0, int rightRange = 10)
{
    int[,,] matrix = new int[rowsCount, columnsCount, lineCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {  
                matrix[i,j,z] = rand.Next(leftRange, rightRange + 1);
            }       
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"{matrix[i,j,z]}({i}, {j}, {z})");
            }
            Console.WriteLine();
        }
    }
}

int[] OdMass(int a, int b, int c)
{
    int[] mass = new int[a*b*c];
    Random rand = new Random();
    for(int i = 0; i < a*b*c; i++)
        {
            mass[i] = rand.Next(10, 99 + 1);
            while (check(i, mass[i], mass))
            {
                mass[i] = rand.Next(10, 99 + 1); 
            }
        }
    return mass;
}

bool check(int a,  int b, int[] mass)
{
    for (int i = 0; i < a; i++)
    {
        if (mass[i] == b)
        {
            return true;
        }
    }
    return false;
}

int[,,] threeMass(int a, int b, int c, int[] matrix)
{
    int count = 0;
    int[,,] result =new int[a, b, c];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            for(int z = 0; z < c; z++)
            {
                result[i,j,z] = matrix[count];
                count++;
            }
        }
    }
    return result;
}


int m = ReadNumber("Введите длину.");
int n = ReadNumber("Введите ширину.");
int p = ReadNumber("Введите высоту.");
while (n*p*m > 90)
{
    Console.WriteLine("Невозможно создать массив. Суммарное кол-во чисел больше 90!");
    m = ReadNumber("Введите длину.");
    n = ReadNumber("Введите ширину.");
    p = ReadNumber("Введите высоту.");
}
PrintMatrix(threeMass(m, n, p, OdMass(m, n , p)));

