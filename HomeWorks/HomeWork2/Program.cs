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

// int Prompt(string msg)
// {
//     Console.WriteLine($"{msg}");
//     return Convert.ToInt32(Console.ReadLine());
// }
// int num = Prompt("Введите число: ");
// int fnum(int num)
// {
// while (num > 999)
// {
//     num /= 10;
// }
// return num % 10;
// }
//     bool check(int number)
// {
// if (num < 100)
// return false;
// else return true;
// }
// if (check(num) != true)
//     Console.WriteLine("В введеном числе третьей цифры нет!");
// else
//     Console.WriteLine($"Третьей цифрой числа {num} является {fnum(num)}");


        //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// int Prompt(string msg)
// {
// Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int num = Prompt("Введите число");
// string ss = "Это не день недели";
// string check(int num)
// {
//     if (num >= 1 && num < 6) ss = "Это будний день";
//     if (num >= 6 && num < 8) ss = "Это выходной день!";

//     return ss;
// }
// Console.WriteLine(check(num));


        // TASK_15.1 Введите число и узнайте каким днем недели в МАЕ оно является:

// int Prompt(string msg)
// {
// Console.WriteLine($"{msg}");
// return Convert.ToInt32(Console.ReadLine());
// }
// int num = Prompt("Введите число и узнайте каким днем недели в МАЕ оно является: ");
// string ss = "Это не день недели";
// string check(int num)
// {
//     if (num >= 1) ss = "Это выходной день! Праздник Весны и Труда!!!";
//     if (num >= 2 && num <= 5) ss = "Это будний день";
//     if (num >= 6 && num <= 8) ss = "Это выходной день!";
//     if (num >= 9) ss = "Это выходной день! ПРАЗДНИК ДЕНЬ ПОБЕДЫ!!!";
//     if (num >= 10 && num <= 12) ss = "Это будний день";
//     if (num >= 13 && num <= 14) ss = "Это выходной день!";
//     if (num >= 15 && num <= 19) ss = "Это будний день";
//     if (num >= 20 && num <= 21) ss = "Это выходной день!";
//     if (num >= 22 && num <= 26) ss = "Это будний день";
//     if (num >= 27 && num <= 28) ss = "Это выходной день!";
//     if (num >= 29 && num <= 31) ss = "Это будний день";
//     if (num >= 32 && num < 99999) ss = "Токого числа в месяце нет!";

//     return ss;
// }
// Console.WriteLine(check(num));