void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix(int[,] matrix)
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
void MassivProizved(int[,] matrix1, int[,] matrix2, int[,] proizvedMass)
{
    for (int i = 0; i < proizvedMass.GetLength(0); i++)
    {
        for (int j = 0; j < proizvedMass.GetLength(1); j++)
        {
            int proizvedenie = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            
            proizvedenie = matrix1[i, j] * matrix2[i, j];
            proizvedMass[i, j] = proizvedenie;
        }
    }
}
Console.Clear();
Console.Write("Введите размер матрицы через пробел, где первое число строки, второе столбцы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size[0], size[1]];
Console.WriteLine("Массив №1:");
InputMatrix(matrix1);
PrintMatrix(matrix1);
int[,] matrix2 = new int[size[0], size[1]];
Console.WriteLine("Массив №2:");
InputMatrix(matrix2);
PrintMatrix(matrix2);
int[,] proizvedMass = new int[size[0], size[0]];
Console.WriteLine($"Произведение первого и второго маcсивов:");
MassivProizved(matrix1, matrix2, proizvedMass);
PrintMatrix(proizvedMass);