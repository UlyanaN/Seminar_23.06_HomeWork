// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3} | ");
            else Console.Write($"{arr[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationOfMatrix(int[,] matr1, int[,] matr2)
{
    int[,] multipMatrix = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (matr1.GetLength(1) != matr2.GetLength(0))
    {
        Console.WriteLine("Матрицы нельзя умножить, так как количество столбцов первой матрицы не равно числу строк второй матрицы");
    }
    else
    {
        // int multipl = 0;
        for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
            {
                for (int k = 0; k < matr2.GetLength(0); k++)
                {
                    multipMatrix[i, j] = multipMatrix[i, j] + matr1[i, k] * matr2[k, j];
                }
            }
        }
    }
    return multipMatrix;
}
int[,] MatrixResult1 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(MatrixResult1);
Console.WriteLine();
int[,] MatrixResult2 = CreateMatrixRndInt(2, 2, 1, 9);
PrintMatrix(MatrixResult2);
Console.WriteLine();
int[,] MultipMatrixResult = MultiplicationOfMatrix(MatrixResult1, MatrixResult2);
PrintMatrix(MultipMatrixResult);