// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите день недели ");
// int Day = Convert.ToInt32(Console.ReadLine());
// if (Day >= 1 && Day <=7) {
// 	if (Day >= 6) {
// 		Console.Write("выходной день");
// 	} else {
// 		Console.Write("рабочий день");
// 	}
// } else {
// 	Console.Write(" Введите дейсвительный день между 1 и 7 ");
// }

//Напишите программу, которая выводит третью цифру ПЯТИЗНАЧНОГО числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 100 &&  number <= 999)
// {
//     Console.WriteLine($"Третья цифра числа: {number % 10}");
// }

// else
// {
//     Console.WriteLine($"Число не трехзначное :Р");
// }

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = ReadInt("Введите трехзначное число: ");
// int amount = number.ToString().Length;

// if (amount < 3 || amount > 3)
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }
// else
// {
//     Console.WriteLine(InCenter(number));
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int InCenter(int a)
// {
    
//     int result = ((a / 10) % 10);
//     return result;
// }