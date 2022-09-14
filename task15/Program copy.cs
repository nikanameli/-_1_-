int[] GetArray(int size, int leftRange, int rightRange)
{

    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int n(int [] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length;)
    {
            summ = summ + arr[i];
            i = i + 2;
    }
    return summ;
}


int[] array = GetArray(10, -5, 10);
Console.WriteLine(string.Join(", ", array));
int M = n(array);
Console.WriteLine(M);
