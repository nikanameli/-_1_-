Console.WriteLine("Введите два числа.");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) 
{
    Console.WriteLine(numberA +"=max");
    Console.WriteLine(numberB +"= min");
}
else 
{
    Console.WriteLine(numberB +"=max");
    Console.WriteLine(numberA +"=min");
}