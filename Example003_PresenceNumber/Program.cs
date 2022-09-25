// Определить, присутствует ли в заданном 
// массиве некоторое число.
// Сделаем уточнение
// 1. Массив задается автоматически
// 2. Искомое число загадывается компьютером

Console.Clear();
int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0; // объявление переменной и инициализация

while (index < count)
{
    array[index] = new Random().Next(1, 101);
    index++;
}

index = 0; // обнуление объявленной выше переменной (без int)
while (index < count)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Число {find} найдено");
    }
    index++;
}

Console.WriteLine("End");