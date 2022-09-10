// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число.");
Console.WriteLine("Введите степень.");
int number = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = number;

if (n > 1)
{
    while (a < n)
    {
        number = number * b;
        a++;
    }
    Console.WriteLine(number);
}
else if (n == 1)
{
    Console.WriteLine("Единица в любой степени равна единице!");
}
else 
{
    Console.WriteLine("Введенное число меньше 0!");
}
