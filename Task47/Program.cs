// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int stringArray = 3;
int column = 4;
double[,] doubleArray = new double[stringArray, column];
Random rnd = new Random();
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < stringArray; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matrix)
{
    for (int i = 0; i < stringArray; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
        }
    }
}
FillArray(doubleArray);
PrintArray(doubleArray);