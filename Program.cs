/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
*/

/*
Console.WriteLine("Введите трехзначное положительное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number > 1000) Console.WriteLine("Ах ты ж хитрюжка! Введи ТРЕХзначное и положительное число, а не это: " + number);

else
{
    number = (number / 10) % 10;

    Console.WriteLine("Вторая цифра введенного числа это: " + number);
}
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) Console.WriteLine("Дружочек, вводи только положительные числа))");
else if (number >= 100)
{
    while (number > 999) // таким образом приведем число к трехзначному
    {
        number = number / 10;
    }
    int thridNumber = number % 10;

    Console.WriteLine("Третья цифра введенного числа это " + thridNumber);
}
else
{
    Console.WriteLine("Третьей цифры в числе " + number + " нет");
}
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет
*/

/*
Console.WriteLine("Введите число от 1 до 7");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Такого " + dayNumber + "-го дня недели пока не существует.");
}

else if (dayNumber == 5)
{
    Console.WriteLine("Бро, не хочу тебя огорчать, но день рабочий... Но с другой стороны - это же пятница! Юххууууу!!!");
}
else if (dayNumber != 6 && dayNumber != 7)
{
    Console.WriteLine("Бро, не хочу тебя огорчать, но день рабочий...");
}
else
{
    Console.WriteLine("Юххууууу, выходной, отжигаем!!!");
}
*/








