// Сформировать трехмерный массив не повторяющимися двузначными числами, показать его построчно на экран, 
// выводя индексы соответствующего элемента
int[,,] matrix = new int [3, 2, 3];
matrix[0, 0, 0] = 55;
matrix[0, 0, 1] = 23;
matrix[0, 0, 2] = 51;
matrix[0, 1, 0] = 10;
matrix[0, 1, 1] = 34;
matrix[0, 1, 2] = 19;
matrix[1, 0, 0] = 76;
matrix[1, 0, 1] = 95;
matrix[1, 0, 2] = 17;
matrix[1, 1, 0] = 25;
matrix[1, 1, 1] = 67;
matrix[1, 1, 2] = 31;
matrix[2, 0, 0] = 21;
matrix[2, 0, 1] = 36;
matrix[2, 0, 2] = 84;
matrix[2, 1, 0] = 13;
matrix[2, 1, 1] = 32;
matrix[2, 1, 2] = 44;

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           for (int k = 0; k < matr.GetLength(2); k++)
        {
            Console.Write(matr[i, j, k] + " " + (i,j,k) + " ");
        }
        Console.WriteLine();
        }
    }
}

PrintArray(matrix);
