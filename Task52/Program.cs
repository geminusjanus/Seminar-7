//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int stringArray = 3;
int column = 4;
int[,] intArray = new int[stringArray, column];
Random rnd = new Random();
void PrintArray(int[,] massive)
{
    for (int i = 0; i < stringArray; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] massive)
{
    for (int i = 0; i < stringArray; i++)
    {
        for (int j = 0; j < column; j++)
        {
            massive[i, j] = rnd.Next(0, 10);
        }
    }
}
FillArray(intArray);
PrintArray(intArray);