// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 | number > 999)
{
    Console.WriteLine("Вы ввели недопустимое число! Пожалуйста, введите трехзначное число:");
    number = Convert.ToInt32(Console.ReadLine());
}
int twoDigit = number / 10;
int secondNumber = twoDigit % 10;
Console.WriteLine($"Второе число: {secondNumber}");


