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
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >10 && arr[i] < 99)
            {
            summ = summ + 1;
            }
    }
    return summ;
}


int[] array = GetArray(123, 0, 151);
Console.WriteLine(string.Join(", ", array));
int M = n(array);
Console.WriteLine(M);
