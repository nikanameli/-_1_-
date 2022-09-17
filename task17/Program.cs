Console.WriteLine("Введите 3 числа.");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Данный треугольник существует");
}
else 
{
    Console.WriteLine("Данный не треугольник существует");
}
