// Найти произведение двух матриц

Console.WriteLine("Введите количество строк первой матрицы (n): ");
int n1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов первой матрицы(m): ");
int m1 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [n1, m1];
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

Console.WriteLine("Введите количество строк второй матрицы (n): ");
int n2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов второй матрицы(m): ");
int m2 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix2 = new int [n2, m2];

if (m1 != n2)
{
    Console.WriteLine("Умножение невозможно");
    return;
}

int[,] FillArray3(int[,] matrix, int[,] matrix2)
{
   int[,] matrix3 = new int[n1,m2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
           matrix3[i,j] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrix3[i,j] += matrix[i,k] * matrix2[k,j];
            }
        }
    }
    return matrix3 ;
}
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
int[,] matrix3 = FillArray3(matrix, matrix2);
PrintArray(matrix3);
