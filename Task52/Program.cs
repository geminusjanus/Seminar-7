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
void PrintArray(int[,] matrix)
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

void FillArray(int[,] matrix)
{
    for (int i = 0; i < stringArray; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
}

double AvrgElements(int [,] intArray)
{
    double avrg = 0;
    int length = 0;
    if (intArray.GetLength(0) > intArray.GetLength(1))
    for (int i = 0; i < intArray.Length; i++)
    {
        
    }
}
FillArray(intArray);
PrintArray(intArray);