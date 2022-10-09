// Задача 32
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.

// Алгоритм
// 1. Создать массив
// 2. Заполнить массив
// 3. Распечатать массив
// 4. Поменять знак элементов массива
// 5. Распечатать новый массив

// Методы
// 1. Метод получения случайного числа
// 2. Метод создания массива
// 3. Метод заполнения массива случайными числами от min до max
// 4. Метод вывода массива на печать
// 5. Метод замена знака элементов массива

#region Методы
// 1. Метод получения случайного числа
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max + 1);
}

// 2. Метод создания массива
int[] CreateArray(int size)
{
    return new int[size];
}

// 3. Метод заполнения массива случайными числами от min до max
void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

// 4. Метод вывода массива на печать
string Print(int[] array)
{
    return "{" + String.Join(", ", array) + "}";
}

// 5. Метод замена знака элементов массива
int[] ReverseSignNumber(int[] numbers)
{
    int size = numbers.Length;
    int[] reverse = new int[size];
    for (int i = 0; i < size; i++)
    {
        reverse[i] = numbers[i] * (-1);
    }
    return reverse;
}
#endregion

Console.Clear();
int[] array = CreateArray(GetIntValue(5, 20));
Fill(array, -99, 99);
Console.WriteLine("Данная программа меняет знак всех элементов массива");
Console.WriteLine($"Старый массив: {Print(array)}");
int[] arrayReverse = ReverseSignNumber(array);
Console.WriteLine($"Новый массив: {Print(arrayReverse)}");
