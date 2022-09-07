Console.Write("Введите 5ти значное число :");
long num = Convert.ToInt64(Console.ReadLine());

long turn(long arg) // Фунция переворота
{
    long n = arg;
    string s = "";

    while (n != 0)
    {
        long num1 = n % 10;
        n = n / 10;
        s = s + num1;
    }
    long num2 = Convert.ToInt64(s);
    return num2;
}
long num_razvorot = turn(num);

if (num_razvorot == num) Console.WriteLine("Да");
else Console.WriteLine("Нет");