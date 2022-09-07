Console.WriteLine("введите х1.");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y1.");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z1.");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите х2.");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите y2.");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите z2.");
int z2 = Convert.ToInt32(Console.ReadLine());


// AB = √(xb — xa)2 + (yb — ya)2 + (zb — za)2

double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"{res:f2}");