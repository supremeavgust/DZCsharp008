// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] InputMatrix()
{
    Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 50);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return matrix;
}

// int[] GetMinimalIndex(int[,] matrix)
// {
//     int max = matrix[0, 0];
//     int[] result = new int[2];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] < max)
//             {
//                 max = matrix[i, j];
//                 matrix[0,j]=max;
//             }
//         }
//     }
//     return result;
// }
void SortToInt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}
Console.Clear();
int[,] matrix = InputMatrix();
Console.WriteLine();
SortToInt(matrix);
PrintArray(matrix);