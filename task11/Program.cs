
Console.WriteLine("Введите число.");
int number = Convert.ToInt32(Console.ReadLine());
int a = 0;
int summ = 0;

if (number > 0)
{
    while (number > 0)
    {
        a = number % 10;
        summ = summ + a;
        number = number / 10;
       
    }
    Console.WriteLine(summ);
}
else 
{
    Console.WriteLine("Ваше число меньше 0!");
}
