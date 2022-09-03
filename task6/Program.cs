Console.WriteLine("Ввыдете порятковый номер недели от 1 до 7.");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA >7 || numberA < 1)
{
    Console.WriteLine("Введенный номер не соответствует условию.");
}
else if (numberA >1 && numberA < 6)
{
    Console.WriteLine($"{numberA} - будний день.");
}
else 
{
    Console.WriteLine($"{numberA} - выходной день.");
}