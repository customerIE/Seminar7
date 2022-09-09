// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
double sum = 0;
double avr = 0;
Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row,col];
Random rnd = new Random();
for(int i=0; i<row; i++) //Заполнение массив аслучайными числами.
    {
        for(int j=0; j<col; j++)
        {
            matrix[i,j] = rnd.Next(1, 10);
            Console.Write(" " + matrix[i,j]);
        }
        Console.WriteLine();
    }
for(int j=0; j<col; j++) //Поиск среднеарифметического столбца
{
    for(int i=0; i<row; i++)
    {
        sum = sum + matrix[i,j];
        avr = sum / row; 
    }
    Console.WriteLine($"Среднее арифметическое в столбце {j} = {avr}");
    sum = 0;
    avr = 0;
}

