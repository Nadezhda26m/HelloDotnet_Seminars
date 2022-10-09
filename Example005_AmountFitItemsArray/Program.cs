// Задача 35: 
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения 
// которых лежат в отрезке [10,99]

// Алгоритм
// 1. Создать массив из 123 элементов
// 2. Заполнить массив случайными числами
// 3. Распечатать массив
// 4. Посчитать количество элементов массива, значения 
// которых лежат в отрезке [10,99]
// 5. Распечатать ответ

// Методы
// 1. Метод создания массива
// 2. Метод заполнения массива случайными числами от min до max
// 3. Методы печати массива (4 разных)
// 4. Метод получения количества элементов массива из отрезка
// Способ узнать время выполнения кода
// Как вывести в методе несколько значений (массив и кортежи)

// 1. Метод создания массива
int[] CreateArray(int size)
{
    return new int[size];
}

// 2. Метод заполнения массива случайными числами от min до max
void FillArray(int[] arr, int min, int max_1)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max_1);
    }
}
// 3. Печать элементов массива через символ-разделитель
// 3.1. Метод печати массива
string Print(int[] array)
{
    return "{" + String.Join(',', array) + "}";
}
// // 3.2. Печать через символ
// Console.WriteLine(String.Join('-', new int[] {1, 2, 3}));
// // 3.3. Печать через строку символов
// Console.WriteLine(String.Join(", ", new int[] {1, 2, 3}));
// // 3.4. Печать через символы при пробеге по массиву
// string Print2 (int[] array)
// {
//     string result = "[";
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length -1) result = result + array[i] + ", ";
//         else result = result + array[i];
//     }
//     return result + "]";
// }

// 4. Метод получения количества элементов массива из отрезка
int AmountFitItemsFromInterval(int[] arr, int min, int max)
{
    int size = arr.Length;
    int amountFit = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] >= min && arr[i] <= max)
        {
            amountFit = amountFit + 1;
        }
    }
    return amountFit;
}

Console.Clear();
int[] numbers = CreateArray(10);
FillArray(numbers, 1, 200);
Console.WriteLine($"Задан массив: {Print(numbers)}");
int fitElem = AmountFitItemsFromInterval(numbers, 10, 99);
Console.WriteLine($"Количество элементов из отрезка [10, 99]: {fitElem}");

// // Способ узнать время выполнения кода
// DateTime dtStart = DateTime.Now;
// // код
// DateTime dtEnd = DateTime.Now;
// Console.WriteLine((dtEnd - dtStart).TotalMilliseconds);

// // Как вывести в методе несколько значений
// // С помощью массива
// int[] Met()
// {
//     return new int[] { 1, 2 };
// }

// // Кортеж 1
// (int, int) Method(int a, int b)
// {
//     return (a + 1, b + 1);
// }

// (int, int) res = a();
// res.Item1;
// res.Item2;

// (int pos, int neg) res = a();
// res.pos;
// res.neg;

// // Кортеж 2
// (int re, int im) method()
// {
//     return (1, 2);
// }
// method().re;
// method().im;