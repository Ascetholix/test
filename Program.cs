
Console.WriteLine("Два отрезка x1,x2 и x3,x4");
Console.Write("Введите точку отрезка x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку отрезка x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку отрезка x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку отрезка x4: ");
int x4 = Convert.ToInt32(Console.ReadLine());
if (x2 > x1)
 if (x1 < x3 && x2 > x3)
  if (x1 < x4 && x2 > x4)
    Console.WriteLine($" Отрезок {x1} до {x2} пересекает {x3} до {x4}");

else if (x1 < x3 && x2 > x3)
      if (x4 > x3)
        Console.WriteLine($"№1 Отрезки перескають точки  от  {x3} до {x2}");
      if (x4 < x3 && x1 > x2)
        Console.WriteLine($"№2 Отрезки пересекают точки от {x3} до {x1}");

else if (x1 < x4 && x2 > x4)
      if (x4 > x3)
        Console.WriteLine($"№3 Отрезки пересекают от {x4} до {x1}");
      if (x4 < x3 && x1 > x2)
        Console.WriteLine($"№4 Отрезки пересекают от {x4} до {x2}");

else if (x1 > x2)
    if (x2 < x3 && x1 > x3)
      if (x2 < x4 && x1 > x4)
        Console.WriteLine($" Отрезки {x2} до {x1} пересекает {x3} до {x4}");

else if (x2 < x3 && x1 > x3)
     if (x4 > x3)
        Console.WriteLine($"№5 Отрезки пересекают точки от {x3} до {x1}");
     if (x4 < x3 && x2 > x1)
        Console.WriteLine($"№6 Отрезки пересекают точки от {x3} до {x2}");

else if (x2 < x4 && x1 > x4)
    if (x4 > x3)
        Console.WriteLine($"№7 Отрезки пересекают точки от {x4} до {x2}");
    if (x4 < x3 && x2 > x1)
        Console.WriteLine($"№8 Отрезки пересекают точки от {x4} до {x1}");


