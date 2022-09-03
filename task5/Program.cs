Console.WriteLine("Введите число.");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA < 100)
{
    Console.WriteLine("Введено число, которое не имеет третьей цифры.");

}
else 
{
    while (numberA > 1000)
    {
        numberA = numberA / 10;
    }
   numberA = numberA % 10;
}
    
Console.WriteLine(numberA);

