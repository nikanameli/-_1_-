int[] GetArray(int size, int rightRange, int leftRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}


int N(int [] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            summ = summ + 1;
        }
    }
    return summ;
}


int[] array = GetArray(5, 999, 100);
Console.WriteLine(string.Join(", ", array));
int M = N(array);
Console.WriteLine($"Количество четных чисел равно {M}");

