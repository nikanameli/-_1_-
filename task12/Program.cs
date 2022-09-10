Console.WriteLine("Введите элементы массива.");
int [] array = new int [8];
int i = 0;

while (i < array.Length)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine(string.Join(", ", array));
