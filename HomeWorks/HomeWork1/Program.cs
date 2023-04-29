// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Input first numbur: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
//     Console.WriteLine($"{num1} -> max namber, {num2} -> min namber");
// }
// else    
// {    
//     Console.WriteLine($"{num1} -> min namber, {num2} -> max namber");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    
// Console.WriteLine("Enter three numbers:");    

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = Math.Max(num1, Math.Max(num2, num3));
// if (max == num1)
// {
//     Console.WriteLine($"{num1} -> max namber");
// }
// else if (max == num2)
// {
//     Console.WriteLine($"{num2} -> min namber");
// }
// else if (max == num3)
// {
//     Console.WriteLine($"{num3} -> max namber");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Enter one number:");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
//     Console.WriteLine($" число {num} является четным");
// else 
//     Console.WriteLine($" число {num} является не четным");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.WriteLine("Enter number:");
// int Num = Convert.ToInt32(Console.ReadLine());
// int evenNum =2;
// if (Num > 1)
// {
//     while(evenNum <= Num)
//     {
//         Console.Write(evenNum + " ");
//         evenNum = evenNum + 2;
//     }
// }