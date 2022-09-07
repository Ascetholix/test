Console.Write("Введите 5ти значное число :");
long num = Convert.ToInt64(Console.ReadLine());

long turn(long arg) // Фунция переворота
{
    long n = arg;
    long N = arg;
    long i = 0;
    string s = "";
    long count = 0;

    while (N != 0)
    {
        N = N / 10;
        count++;
    }
    while (i < count)
    {
        long num1 = n % 10;
        n = n / 10;
        s = s + num1;
        i++;
    }
    long num2 = Convert.ToInt64(s);
    return num2;
}
long num3 = turn(num);
if (num3 == num) Console.WriteLine("Да");
else Console.WriteLine("Нет");

