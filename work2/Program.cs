// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент
Console.WriteLine("Введите количество строк (n): ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов (m): ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int [n, m];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random random = new Random();
            matr[i, j] = random.Next(-100, 100);
        }
    }
}
int row = 0; 
int column = 0;
void SmallestElement(int[,] matr)
{
    int MinElement = 0;
    MinElement = matr[0,0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        if (MinElement > matr[i,j])
        {
            MinElement = matr[i,j];
            row = i;
            column = j;
        }
    }
}
int[,] FillArrayDelete(int[,] matr)
{
   int[,] NewMatrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           
           int i_ = i;
           int j_ = j;
           if (i != row && j != column)
           {
            if (i > row)
                i_ -= 1;
            if (j > column)
                j_ -= 1;
           NewMatrix[i_,j_] = matr[i,j];
           }
        }
    }
    return NewMatrix;
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

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SmallestElement(matrix);
int[,] matrix2 = FillArrayDelete(matrix);
PrintArray(matrix2);