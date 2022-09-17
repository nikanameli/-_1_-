Console.WriteLine("Введите b1");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
float k2 = Convert.ToInt32(Console.ReadLine());
float x = 0;
float y = 0;

x = (b2 - b1)/(k1 - k2);
y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых будет находится на координатах ({x};{y})");