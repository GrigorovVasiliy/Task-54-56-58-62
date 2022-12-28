void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11);
    }
}
void PrintMatrix (int[,] matrix)
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
int Summa(int[,] matrix, int i)
{
  int sum = matrix[i,0];
  for (int j = 1; j < matrix.GetLength(1); j++)
  {
    sum += matrix[i,j];
  }
  return sum;
}
Console.Clear();
Console.Write("Введите размер матрицы через пробел, где первое число строки, второе столбцы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Массив:");
InputMatrix(matrix);
PrintMatrix(matrix);

int minSumStroki = 0;
int sumStroki = Summa(matrix, 0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
  int tempSumStroki = Summa(matrix, i);
  if (sumStroki > tempSumStroki)
  {
    sumStroki = tempSumStroki;
    minSumStroki = i;
  }
}
Console.WriteLine($"Cтрокa с минимальной суммой элементов - {minSumStroki+1}");