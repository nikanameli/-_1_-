Console.WriteLine("Введите трехзначное число.");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (number < 100 | number > 999)
{
    Console.WriteLine("Число не соответствует условию.");
}
else 
{
    int digital1 = number / 100;
    int digital2 = number / 10;
    result = digital2 - digital1*10;
    Console.WriteLine(result);
}