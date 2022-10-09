// 60. Составить частотный словарь элементов линейного массива
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.
// Пример: есть набор данных { 1, 9, 9, 0, 2, 8, 0, 9 }
// Частотный массив может быть представлен так:
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// Методы
// 1. Метод получения случайного числа
// 2. Метод создания массива
// 3. Метод заполнения массива случайными числами от min до max
// 4. Метод вывода массива на печать
// 5. Метод, который считает, сколько раз встречается элемент в массиве
// 6. Метод поиска максимального элемента не пустого массива
// 7. Метод поиска минимального элемента не пустого массива

#region Вариант третий, от преподавателя    
int[] array = { 0, 5, 3, 9, 1, 9, 6, 0, 0, 1, 4, 4, 6, 7, 8, 9 };
int[] count = new int[array.Max() + 1]; // array.Max() выдает максимальный элемент массива
// так как нужно показать частоту чисел от 0, то количество
// элементов в новом массиве д.б. на 1 больше максимального элемента
// 0 1 2 3 4 5 6 7 8 9
// 3 2 0 1 2 1 2 1 1 3
for (int i = 0; i < array.Length; i++) count[array[i]]++;
for (int i = 0; i < count.Length; i++)
{
    if (count[i] != 0)
    {
        Console.WriteLine($"{i} встречается {count[i]} р");
    }
}
#endregion

#region Вариант второй
// // 1. Метод получения случайного числа
// int GetIntValue(int min, int max)
// {
//     return new Random().Next(min, max + 1);
// }

// // 2. Метод создания массива
// int[] CreateArray(int size)
// {
//     return new int[size];
// }

// // 3. Метод заполнения массива случайными числами от min до max
// void Fill(int[] array, int min, int max)
// {
//     int size = array.Length;
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
// }

// // 4. Метод вывода массива на печать
// string Print(int[] array)
// {
//     return "{" + String.Join(", ", array) + "}";
// }
  
// // 5. Метод, который считает, сколько раз встречается элемент в массиве
// int CountElements(int[] array, int number)
// {
//     int count = 0;
//     int size = array.Length;
//     for (int i = 0; i < size; i++)
//     {
//         if (array[i] == number) count++;
//     }
//     return count;
// }

// Console.Clear();
// int[] arr = CreateArray(20);
// Fill(arr, 0, 15);
// Console.WriteLine(Print(arr));
// for (int i = arr.Min(); i <= arr.Max(); i++)
// {
//     if (CountElements(arr, i) > 0) // много прогонов массива
//     {
//         Console.WriteLine($"Элемент {i} встречается {CountElements(arr, i)} р");
//     }
// }
#endregion

#region Вариант первый, групповая работа
// 1. Метод поиска максимального элемента не пустого массива
int MaxElements(int[] array)
{
    int size = array.Length;
    int max = array[0]; // в массиве должен быть мин 1 элемент
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

// 2. Метод поиска минимального элемента не пустого массива
int MinElements(int[] array)
{
    int size = array.Length;
    int min = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

// 3. Метод, который считает, сколько раз встречается элемент в массиве
int CountElements(int[] array, int number)
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] == number) count++;
    }
    return count;
}

// 4. Метод вывода массива на печать
string Print(int[] array)
{
    return "{" + String.Join(", ", array) + "}";
}
//                      1  4  4  1  0  3  2  4    
int[] arr = new int[] { 4, 9, 9, 4, 2, 8, 5, 9 };
Console.WriteLine(Print(arr));
int min = MinElements(arr);
int max = MaxElements(arr);
for (int i = min; i <= max; i++)
{
    if (CountElements(arr, i) > 0) // много прогонов массива
    {
        Console.WriteLine($"Элемент {i} встречается {CountElements(arr, i)} раз");
    }
}
#endregion