// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int Promt(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void PrintAverArray(double[] array)
{
    foreach (double element in array)
        System.Console.Write($"{element:F2}; ");
    System.Console.WriteLine();
}

double[] FindAverageInColumn(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            temp += array[i, j];
        averageArray[j] = temp / array.GetLength(0);
    }
    return averageArray;
}


int row = Promt("введите количесво строк: ");
int column = Promt("введите количесво столбцов: ");
int min = 0;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
double[] averageArray = FindAverageInColumn(array);
System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintAverArray(averageArray);
