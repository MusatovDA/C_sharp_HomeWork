// Console.WriteLine("Input numbers:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"You input {{{num}}} numbers");

// Task1 Запросить число и вывести его квадрат

//  Console.WriteLine("Input numbers:");
//  int num = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine($"Quad of {num} -> {num*num}");

//  Task2 Является ли первое число квадратом второго

Console.WriteLine("Input first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2*num2)
{
    Console.WriteLine($"{num1} является квадратом {num2}");
}
    Console.WriteLine($"{num1} не является квадратом {num2}");
