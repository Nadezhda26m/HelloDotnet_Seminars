// Задача 31
// Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. Найдите сумму отрицательных 
// и положительных элементов массива.

// Алгоритм
// 1. Создать массив из 12 элементов
// 2. Заполнить массив случайными числами из промежутка [-9, 9]
// 3. Распечатать получившийся массив
// 4. Найти сумму положительных элементов массива
// 5. Найти сумму отрицательных элементов массива

// Методы
// 1. Метод создания массива
// 2. Метод заполнения массива случайными числами от min до max
// 3. Метод печати массива
// 4. Метод нахождения суммы положительных элементов массива
// 5. Метод нахождения суммы отрицательных элементов массива
// 6. Метод нахождения суммы положительных и отрицательных элементов массива

#region Методы
// 1. Метод создания массива
int[] CreateArray(int size)
{
    return new int[size];
}

// 2. Метод заполнения массива случайными числами от min до max
void Fill(int[] array, int min, int max)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

// 3. Метод печати массива
string Print(int[] array)
{
    return "{" + String.Join(", ", array) + "}";
}

// 4. Метод нахождения суммы положительных элементов массива
int sumPositiveItems(int[] array)
{
    int sumPos = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) sumPos = sumPos + array[i];
    }
    return sumPos;
}


// 5. Метод нахождения суммы отрицательных элементов массива
int sumNegativeItems(int[] array)
{
    int sumNeg = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] < 0) sumNeg = sumNeg + array[i];
    }
    return sumNeg;
}

// 6. Метод нахождения суммы положительных и отрицательных элементов массива
int[] sumPositiveAndNegativeItems(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) sumPos = sumPos + array[i];
        else if (array[i] < 0) sumNeg = sumNeg + array[i];
    }
    return new int[] { sumPos, sumNeg };
}
#endregion

Console.Clear();
int[] array = CreateArray(12);
Fill(array, -9, 9);
Console.WriteLine($"Задан массив: {Print(array)}");
Console.WriteLine($"Сумма положительных элементов: {sumPositiveItems(array)}");
Console.WriteLine($"Сумма отрицательных элементов: {sumNegativeItems(array)}");
// int[] sumPosNeg = sumPositiveAndNegativeItems(array); // Метод 6
// Console.WriteLine($"Сумма положительных элементов 2: {sumPosNeg[0]}");
// Console.WriteLine($"Сумма отрицательных элементов 2: {sumPosNeg[1]}");
