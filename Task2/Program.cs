// Задача 50. Напишите программу, которая на вход принимает позиции (две) элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
int[,] matrix = new int[,]  // Исходный массив.
{ 
    {5, 7, 10, 20},
    {67, 17, 18, 8},
    {4, 34, 2, 7}
};
Console.Write("Введите номер строки элемента массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента массива: ");
int col = Convert.ToInt32(Console.ReadLine());
if((row<matrix.GetLength(0)) && (col<matrix.GetLength(1)))
    {
        int result = matrix[row, col];
        Console.WriteLine($"Элемент [{row}, {col}] = {result}");
    }
else
    {
        Console.WriteLine("Такого элемента нет!");
    }
