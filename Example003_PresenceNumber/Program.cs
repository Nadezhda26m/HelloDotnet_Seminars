﻿// Определить, присутствует ли в заданном 
// массиве некоторое число.
// Сделаем уточнение
// 1. Массив задается автоматически
// 2. Искомое число загадывается компьютером

Console.Clear();
int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0; // объявление переменной и инициализация
Console.WriteLine($"Ищем число {find}");
Console.Write("Массив: ");

while (index < count)
{
    array[index] = new Random().Next(1, 101);
    Console.Write(array[index] + " ");
    index++;
}
// Console.WriteLine();
index = 0; // обнуление объявленной выше переменной (без int)
bool flag = false;
while (index < count)
{
    if (array[index] == find)
    {
        flag = true;
    }
    index++;
}
// if (flag == true) читается как "если истина равна истине"
// так писать не принято
// при обратной задаче будет записываться 
// if (!flag) если не true/false
if (flag)
{
    Console.WriteLine($"\nТакое число есть"); // \n добавляет переход на новую строку перед текстом
}
else
{
    Console.WriteLine($"\nТакого числа нет");
}
