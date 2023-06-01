// Задача №1. Напишите цикл который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
int Promt (string message)
{
	Console.Write(message); // Вводим приглашение ко вводу
	string readInput = Console.Readline(); // Вводим значение
	int result = int.Parse(readInput); // приводим к числу
	return result; // возвращаем результат
}

int Power(int powerBase, int exponent);
{
	int power = 1;
	for (int i = 0; i < exponent; i++)
	{
	power *= powerBase;
	}
	return power;
}

bool ValidateExponent(int exponent)
{
	if (exponent < 0 )
	{
	Console.WriteLine("Показатель не должен быть меньше нуля");
	return felse;
	}
	return true;
}
int powerBase = Promt ("Введите основание: ");
int exponent = Promt ("Введите показатель: ");
if (ValidateExponent(exponent))
{
Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase,exponent)}");
}

// // Задача №2. Напишите программу которая принимает на вход число и выдает сумму цифр в числе.

// int Promt (string message)
// {
// 	System.Console.Write(message); // Вводим приглашение ко вводу
// 	string readInput = Console.Readline(); // Вводим значение
// 	int result = int.Parse(readInput); // приводим к числу
// 	return result; // возвращаем результат
	
// } 
// int SummAllDigit(int num);
// {
// 	int result = 0;
// 	while (num > o)
// 	{
// 		result += num % 10;
// 		num = num / 10;
// 	}
// 	return result;
// }
// int num = Promt("Введите число: ");
// System.Console.WriteLine($"Сумма всех чисел в цифре {num} = {SummAllDigit(num)}");

// // Задача №3. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// int Promt (string message)
// {
// 	System.Console.Write(message); // Вводим приглашение ко вводу
// 	string readInput = Console.Readline(); // Вводим значение
// 	int result = int.Parse(readInput); // приводим к числу
// 	return result; // возвращаем результат
// }
// // метод для получения случайных значений массива
// int [] GenerateArray(int Length, int minValue, maxValue)
// {
// 	int[] array = new int[length]; // объявляем массив
// 	Random random = new Random();
// 	for (int i = 0; i < Length; i++)
// 	{
// 		array[i] = random.Next(minValue, maxValue + 1); //заполняем случайными цифрами из диапазона 
// 		// SatrArr до EndArr
// 	}
// 	return array;
// }

// void printArray(int[] array)
// {
// 	System.Console.Write("[");
// 	for (int i = 0; i < array.Length - 1; i++)
// 	{
// 		System.Console.Write($"{array[i]}, "); //вывод значени массива
// 	}
// 	System.Console.Write($"{array[array.Length - 1]}");  //  вывод значения массива
// 	System.Console.WriteLine("[");
// }

// int length = Promt("Длинна массива: ");
// int min = Promt("Начальное значение, для диапозона случайного числа:" );
// int max = Promt("Конечное число, для диапозона случайного числа: ");
// int [] array = GenerateArray(length, min, max); //  заполнение массива случайными числами
// printArray(array);

