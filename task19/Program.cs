Console.WriteLine("Введите числа");
string number = Console.ReadLine();
int a = 0;
while (number != "stop")
{
    int number1 = Convert.ToInt32(number);
    if (number1 > 0)
    {
        a++;
    }
    number = Console.ReadLine();
}
Console.WriteLine(a);