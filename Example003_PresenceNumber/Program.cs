// Определить, присутствует ли в заданном 
// массиве некоторое число.
// Сделаем уточнение
// 1. Массив задается автоматически
// 2. Искомое число загадывается компьютером

Console.Clear();
int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;
Console.WriteLine($"Ищем число {find}");
Console.Write("Массив: ");

while (index < count)
{
    array[index] = new Random().Next(1, 101);
    Console.Write(array[index] + " ");
    index++;
}

index = 0;
bool flag = false;
while (index < count)
{
    if (array[index] == find)
    {
        flag = true;
    }
    index++;
}

if (flag)
{
    Console.WriteLine($"\nТакое число есть");
}
else
{
    Console.WriteLine($"\nТакого числа нет");
}
