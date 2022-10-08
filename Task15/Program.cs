// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// switch(number)
// {
// case 1:
// Console.WriteLine("нет");
// break;
// case 2:
// Console.WriteLine("нет");
// break;
// case 3:
// Console.WriteLine("нет");
// break;
// case 4:
// Console.WriteLine("нет");
// break;
// case 5:
// Console.WriteLine("нет");
// break;
// case 6:
// Console.WriteLine("да");
// break;
// case 7:
// Console.WriteLine("да");
// break;
// default:
// Console.WriteLine("Нет такого дня недели");
// break;
// }

// Console.WriteLine("Введите день недели от 1 до 7:");
// int number = Convert.ToInt32(Console.ReadLine());
// while (number < 1 | number > 7) 
// {
// Console.WriteLine("В неделе 7 дней, введите номер дня недели от 1 до 7:");
// number = Convert.ToInt32(Console.ReadLine());
// }
// if (number == 6| number == 7) Console.Write("да");
// else Console.WriteLine("нет");


Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1 | number > 7)
{
    Console.WriteLine("В неделе 7 дней, введите номер дня недели от 1 до 7:");
    number = Convert.ToInt32(Console.ReadLine());
}

if (dayOff(number))
    Console.WriteLine("да");
else Console.WriteLine("нет");

bool dayOff(int num)
{
    return num == 6 || num == 7;
}
