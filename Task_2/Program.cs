// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

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

string FindArrayElement(int[,] array, int rowPosition, int columnPosition)
{
    string result = "";
    if (rowPosition < 1 || columnPosition < 1 || rowPosition > array.GetLength(0) || columnPosition > array.GetLength(1))
    {
        result = $"на введенной позиции {rowPosition}; {columnPosition} элемента нет";
    }
    else
    {
        result = $"на введенной позиции {rowPosition}; {columnPosition} находится элемент {array[rowPosition - 1, columnPosition - 1]}";
    }

    return result;
}


int row = Promt("введите количесво строк: ");
int column = Promt("введите количесво столбцов: ");
int min = 0;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
int rowPosition = Promt("введите номер строки: ");
int columnPosition = Promt("введите номер столбца: ");
System.Console.WriteLine(FindArrayElement(array, rowPosition, columnPosition));