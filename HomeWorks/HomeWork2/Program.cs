//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >=100 && num <1000)
// {
// int mid = (num % 100 -num % 10) / 10;
//     Console.WriteLine($"Второй цифрой числа {num} является цифра {mid}");
// }
// else
//     Console.WriteLine("Это число не является трехзначным!");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string msg)
{
Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());
}
int num = Prompt("Введите число: ");

int fnum(int num)
{
while (num > 999)
{
num /= 10;
}
return num % 10;
}

bool check(int number)
{
if (num < 100)
return false;
else return true;
}

if (check(num) != true)
System.Console.WriteLine("В введеном числе третьей цифры нет!");
else
System.Console.WriteLine($"Третьей цифрой числа {num} является {fnum(num)}");