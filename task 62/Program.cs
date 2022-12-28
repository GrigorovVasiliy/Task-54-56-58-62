void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] / 10 <= 0)
                Console.Write($"{matrix[i, j]}\t");

            else Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите размер квадратной матрицы: ");
int a = int.Parse(Console.ReadLine());
int[,] matrix = new int[a, a];
int start = 1, i = 0, j = 0;
while (start <= matrix.GetLength(0) * matrix.GetLength(1))
{
    matrix[i, j] = start;
    start++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1) i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1) j--;
    else i--;
}
PrintMatrix(matrix);