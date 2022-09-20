/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.Write("Ведите трехзначное число: ");
int value = int.Parse(Console.ReadLine());
if (value / 100 == 0 || value / 100 >= 10) {
    Console.WriteLine("Вы ввели не трехзначное число");
    return;
}
int find = (value / 10) % 10;
Console.WriteLine($"Вторая цифра числа: {find}");

