/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Введите цыфру, соответствующую дню недели: ");
int numberDay = int.Parse(Console.ReadLine());
if (numberDay < 1 || numberDay > 7) {
    Console.WriteLine("Такого дня недели не существует");
    return;
}
if (numberDay == 6 || numberDay == 7) {
    Console.WriteLine("Да, это выходной");
} else {
    Console.WriteLine("Нет, это рабочий день");
}