Console.WriteLine("Два отрезка x1,x2 и x3,x4");
Console.Write("Введите точку отрезка x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку отрезка x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку отрезка x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку отрезка x4: ");
int x4 = Convert.ToInt32(Console.ReadLine());

if (x1 < x3 && x2 > x3)
{
    if (x1 < x4 && x2 > x4)
    {
        Console.WriteLine($"Отрезок от {x1} до {x2} пересекает отрезок от {x3} до {x4}");
        Console.WriteLine($"в точках от{x3} до {x4}");
    }
}
else if (x1 < x3 && x2 > x3)
{
    Console.WriteLine($"Отрезок от {x1} до {x2} пересекает отрезок от {x3} до {x4}");
    Console.WriteLine($"В точке {x3}");
}
else if (x1 < x4 && x2 > x4)
{
    Console.WriteLine($"Отрезок от {x1} до {x2} пересекает отрезок от {x3} до {x4}");
    Console.WriteLine($"В точке {x4}");
}
else
{
    Console.WriteLine("Отрезки непересекаються");
}