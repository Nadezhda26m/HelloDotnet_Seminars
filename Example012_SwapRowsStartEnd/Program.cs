// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.

// Алгоритм
// 1. Задать двумерный массив
// 2. Заполнить массив
// 3. Распечатать исходный массив
// 4. Поменять местами первую и последнюю строки массива
// 5. Распечатать получившийся массив

// Методы
// 1. Метод создания двумерного массива
// 2. Метод заполнения двумерного массива 
// случайными числами из отрезка [min, max]
// 3. Метод печати двумерного массива через разделитель
// 4. Метод обмена первой и последней строк двумерного массива

#region Методы
// 1. Метод создания двумерного массива
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

// 2. Метод заполнения двумерного массива 
// случайными числами из отрезка [min, max]
void Fill(int[,] matrix, int min, int max)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// 3. Метод печати двумерного массива через разделитель
void Print(int[,] matrix, string separator)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        Console.Write("{ ");
        for (int j = 0; j < col - 1; j++)
        {
            Console.Write(matrix[i, j] + separator);
        }
        Console.WriteLine(matrix[i, col - 1] + " }");
    }
}

// 4. Метод обмена первой и последней строк двумерного массива
void SwapRowsStartEnd(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int j = 0; j < col; j++)
    {
        int help = matrix[0, j];
        matrix[0, j] = matrix[row - 1, j];
        matrix[row - 1, j] = help;
    }
}
#endregion Методы

Console.Clear();
int[,] matr = CreateMatrix(5, 7);
Fill(matr, 10, 99);
Console.WriteLine("Задан двумерный массив:");
Print(matr, ", ");
Console.WriteLine();
Console.WriteLine("Поменяли первую и последнюю строки "
                + "в заданном массиве:");
SwapRowsStartEnd(matr);
Print(matr, ", ");
