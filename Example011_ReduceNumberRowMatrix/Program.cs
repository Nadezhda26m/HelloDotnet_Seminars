// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Методы
// Метод получения случайного целого числа
// Метод для создания двумерного массива
// Метод для заполнения матрицы
// Метод для печати матрицы
// Метод упорядочивания чисел в строке по убыванию

#region Методы    
// Метод получения случайного целого числа
int GetIntValue(int min, int max)
{
    return new Random().Next(min, max + 1);
}

// Метод для создания двумерного массива
int[,] CreateMatrix(int row, int col)
{
    return new int[row, col];
}

// Метод для заполнения матрицы
void FillMatrix(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
}

// Метод для печати матрицы
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод упорядочивания чисел в строке по убыванию
// 1 2 3 4  n элементов
// 2 3 4 1  1 прогон
// 3 4 2 1  2 прогон
// 4 3 2 1  3 прогон
// n-1 прогонов для упорядочивания строки
void ArrangeRowInDecreasingOrder(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int col = matrix.GetLength(1);
    for (int i = 0; i < row; i++)
        for (int k = 0; k < col - 1; k++) // прогонов на 1 меньше col
            for (int j = 0; j < col - 1; j++) // не выходим за длину строки
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
}
#endregion

Console.Clear();
int[,] matrix = CreateMatrix(GetIntValue(4, 6), GetIntValue(4, 6));
FillMatrix(matrix, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
ArrangeRowInDecreasingOrder(matrix);
PrintMatrix(matrix);
