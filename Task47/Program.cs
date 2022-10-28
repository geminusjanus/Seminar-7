// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк двумерного массива:");
int stringArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int column = Convert.ToInt32(Console.ReadLine());
double[,] doubleArray = new double[stringArray, column];
Random rnd = new Random();
void PrintArray(double[,] massive)
{
    for (int i = 0; i < stringArray; i++)
    {
        for (int j = 0; j < column; j++)
        { Console.Write($"{massive[i, j]} "); }
        Console.WriteLine();
    }
}

void FillArray(double[,] massive)
{
    for (int i = 0; i < stringArray; i++)
    {
        for (int j = 0; j < column; j++)
        { massive[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); }
    }
}
FillArray(doubleArray);
PrintArray(doubleArray);