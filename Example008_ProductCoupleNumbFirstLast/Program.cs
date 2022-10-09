// Задача 37
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве

// Алгоритм
// 1. Задать массив
// 2. Заполнить массив
// 3. Распечатать массив
// 4. Создать новый массив
// 5. Заполнить новый массив элементами, равными  
// произведению пар чисел из первого массива
// Для исходного массива с нечетным количеством элементов
// будем умножать центральный элемент сам на себя
// 6. Распечатать новый массив

// Методы
// 1. Метод получения случайного числа
// 2. Метод создания массива
// 3. Метод заполнения массива случайными числами от min до max
// 4. Метод вывода массива на печать
// 5. Метод заполнения массива элементами, равными  
// произведению пар чисел (с обоих концов) из другого массива

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

// 5. Метод заполнения массива элементами, равными  
// произведению пар чисел (с обоих концов) из другого массива
int[] ProductCoupleNumbFirstLast(int[] array)
{
    int size = array.Length;
    int sizeProduct = size / 2 + 1;
    if (size % 2 == 0) sizeProduct = size / 2;
    int[] arrProduct = new int[sizeProduct];
    for (int i = 0; i < sizeProduct; i++)
    {
        arrProduct[i] = array[i] * array[size - 1 - i];
    }
    return arrProduct;
}
#endregion

Console.Clear();
int[] array = CreateArray(GetIntValue(4, 15));
Fill(array, -20, 20);
Console.WriteLine("Данная программа находит произведение пар чисел первого и последнего,");
Console.WriteLine("второго и предпоследнего элементов массива и т.д. и записывает");
Console.WriteLine("результат в новый массив");
Console.WriteLine($"Задан массив: {Print(array)}");
int[] arrayCouple = ProductCoupleNumbFirstLast(array);
Console.WriteLine($"Новый массив: {Print(arrayCouple)}");
