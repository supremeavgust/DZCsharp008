// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 5);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void InputPrimer(int[,] matrix, int[,] matrix2,int[,] result)
{
if (matrix.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        result[i, j] = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            result[i, j] += matrix[i, k] * matrix2[k, j];
        }

    }         
}
}
void PrintRT(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];
int[,] result = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine();
InputMatrix(matrix2);
Console.WriteLine();
InputPrimer(matrix, matrix2, result);
PrintRT(result);
