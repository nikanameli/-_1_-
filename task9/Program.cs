Console.WriteLine("Введите пятизначное число.");
int number = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 0;
int c = 0;
int d = 0;

if (number > 99999 || number < 10000)
{
    Console.WriteLine("Число не является пятизначным.");
}
else
{
    a = number / 10000;
    b = number % 10;
    c = number / 1000;
    c = c % 10;
    d = number % 100;
    d = d / 10;
    
    if ((a == b) && (c == d))
    {
        Console.WriteLine("Ваше число палиндром.");
    }
    else
    {
         Console.WriteLine("Ваше число не палиндром.");
    }
}


