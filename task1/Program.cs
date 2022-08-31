Console.WriteLine("Введите 3 числа.");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
    {
        Console.WriteLine(numberA);
    }
else if (numberB > numberA && numberB > numberC)
    {
        Console.WriteLine(numberB);
    }
else 
{
    Console.WriteLine(numberC);
}
