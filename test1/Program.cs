
Console.Write("Введите 5ти значное число :");
int num = Convert.ToInt32(Console.ReadLine());

int n = num;
int N = num;
int i = 0;
string s = "";
int count = 0;

while (N != 0)
{
    N = N / 10;
    count++;
}

while (i < count)
{
    int num1 = n % 10;    // 5
    n = n / 10;
    s = s + num1;
    i++;
    Console.WriteLine(num1);
}
int num2 = Convert.ToInt32(s);
Console.WriteLine(num2);

if (num2 == num) Console.WriteLine("Да");
else Console.WriteLine("Нет");



