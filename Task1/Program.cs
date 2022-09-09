// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными (тип double) числами.
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m,n];
void PrintArray(double[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
Random rnd = new Random();
void FillArray(double[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.NextDouble();
        }
    }
}
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);