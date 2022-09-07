Console.Clear();

Console.Write("Введите 5ти значное число :");
int num = Convert.ToInt32(Console.ReadLine());
int t = num;
int sum = 0;
int r = 0;

while (num != 0)
{
    r = num % 10;
    num = num / 10;
    sum = sum * 10 + r;
}
if (t == sum)
{
    Console.WriteLine($"{t}--->Да");
}
else
{
    Console.WriteLine($"{t}--->Нет");
}