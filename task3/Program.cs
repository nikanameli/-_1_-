Console.WriteLine("Введите число.");
int numberA = 1;
int numberB = Convert.ToInt32(Console.ReadLine());

while (numberA < numberB - 1)
{   
    if (numberA % 2 == 0)
        {
            Console.WriteLine(numberA = numberA + 2);
        }
    else 
    {
        Console.WriteLine(numberA = numberA + 1);
    }
}