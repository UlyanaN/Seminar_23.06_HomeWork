// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int[,,] CreateThreeDemMatrixInt(int m, int n, int l, int min, int max)
{
    int[,,] matr = new int[m, n, l];
    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = rnd.Next(min, max);
                min += 1;
                max +=1;
            }
        }
    }
    return matr;
}

void PrintThreeDemMatrix(int[,,] matrr)
{
    for (int i = 0; i < matrr.GetLength(0); i++)
    {
        for (int j = 0; j < matrr.GetLength(1); j++)
        {
            for (int k = 0; k < matrr.GetLength(2); k++)
            {
                if (k == 0) Console.WriteLine();
                if (k < matrr.GetLength(2) - 1) Console.Write($"{matrr[i, j, k],3} ");
                else Console.Write($"{matrr[i, j, k],3} ");
                Console.Write($"({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}


int[,,] arrayResult = CreateThreeDemMatrixInt(2, 2, 2, 10, 11);
PrintThreeDemMatrix(arrayResult);