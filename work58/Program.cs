// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] matr = new int [2, 2];
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random random = new Random();
            matr[i, j] = random.Next(-10, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matr2 = new int [2, 2];
void FillArray2(int[,] matr2)
{
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            Random random = new Random();
            matr2[i, j] = random.Next(-10, 10);
        }
    }
}
void PrintArray2(int[,] matr2)
{
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            Console.Write($"{matr2[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matr3 = new int [2, 2];
void FillArray3(int[,] matr3)
{
    for (int i = 0; i < matr3.GetLength(0); i++)
    {
        for (int j = 0; j < matr3.GetLength(1); j++)
        {
            matr3[0, 0] = matr[0, 0] * matr2[0, 0] + matr[0, 1] * matr2[1, 0];
            matr3[0, 1] = matr[0, 0] * matr2[0, 1] + matr[0, 1] * matr2[1, 1];
            matr3[1, 0] = matr[1, 0] * matr2[0, 0] + matr[1, 1] * matr2[1, 0];
            matr3[1, 1] = matr[1, 0] * matr2[0, 1] + matr[1, 1] * matr2[1, 1];
        }
    }
}
void PrintArray3(int[,] matr3)
{
    for (int i = 0; i < matr3.GetLength(0); i++)
    {
        for (int j = 0; j < matr3.GetLength(1); j++)
        {
            Console.Write($"{matr3[i,j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(matr);
PrintArray(matr);
Console.WriteLine();
FillArray2(matr2);
PrintArray2(matr2);
Console.WriteLine();
FillArray3(matr3);
PrintArray3(matr3);