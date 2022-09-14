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
    int diff = 0;
    int max = 0;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i ++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
       
        if (arr[i] < min)
        {
            min = arr[i];
        }

    }
    diff = max - min;
    return diff;
}

int[] array = GetArray(5, -10, 10);
Console.WriteLine(string.Join(", ", array));
int M = n(array);
Console.WriteLine(M);
