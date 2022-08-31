Console.WriteLine("Введите число.");
int numberA = Convert.ToInt32(Console.ReadLine());

 if (numberA % 2 == 1 || numberA % 2 == -1)
 {
    Console.WriteLine("Число нечетное.");
 }
else
{
    Console.WriteLine("Число четное");
}