// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите 5ти значное число :");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
int n = num;

// int razdel(int result)
// {
// int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
// int n = result;

//     num1 = n % 10;    // 5
//     n = n / 10;       //1234
//     num2 = n % 100;    // 4
//     n = n / 10;       //123  
//     num3 = n % 10;    // 3
//     n = n / 10;       //12
//     num4 = n % 10;    // 2
//     num5 = n / 10;    // 1
//     if (num1 == num5 && num2 == num4)
// return 
// }

if (num > 9999 && num < 100000)
{                                //12345
    num1 = n % 10;    // 5
    // n = n / 10;       //1234
    num2 = n % 100;    // 4
    // n = n / 10;       //123  
    num3 = n % 1000;    // 3
    // n = n / 10;       //12
    num4 = n % 10000;    // 2
    num5 = n % 100000;    // 1


    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($"{num} являеться палиндромом {num1}{num2}{num3}{num4}{num5}");
    }
    else 
    {
        Console.WriteLine("Не являеться палиндромом");
    }
}
else 
Console.WriteLine("Не 5ти значное число ");


