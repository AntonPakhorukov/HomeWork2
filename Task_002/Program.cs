/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Clear();
Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine());
if (value < 0) value = -value;
if (value / 100 == 0) {
    Console.WriteLine("Третьей цифры нет");
    return;
}
int third;
if (value < 1000) {
    third = value % 10;
} else {
    while (value > 1000) {
        value = value / 10;
        }
    third = value % 10;
}
Console.WriteLine(third);
