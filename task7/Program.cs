Console.WriteLine("Введите положительное число.");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

if ( N <= 0 )
{ 
    Console.WriteLine("Число не соответсвует условию.");
}
else 
{
    while ( i <= N )
    {
        Console.Write( i*i*i + " ");
        i++;
    }
}
