// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double randomRealNumbers()
{
    Random rnd = new Random();
    double num = rnd.NextDouble();
    double whol = rnd.Next(-10, 10);
    double numbers = Math.Round(num + whol, 1);
    return numbers;
}

int EnterNum(string text)
{
    System.Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[,] arrayFilling(int lines, int columns)
{
    double[,] myArray = new double[lines, columns];

    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = randomRealNumbers();
        }
    }
    return myArray;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 0)
            {
                System.Console.Write($"{array[i, j]}\t");
            }
            else
            {
                System.Console.Write($" {array[i, j]}\t");
            }
        }
        System.Console.WriteLine();
    }
}

int ValidatingParameterLines(int lines)
{
    if (lines < 2)
    {
        lines = ValidatingParameterLines(EnterNum("Введите колличество строк: "));
    }
    return lines;
}

int ValidatingParameterColumns(int columns)
{
    if (columns < 2)
    {
        columns = ValidatingParameterColumns(EnterNum("Введите колличество столбцов: "));
    }
    return columns;
}

int lines = ValidatingParameterLines(EnterNum("Введите колличество строк: "));
int columns = ValidatingParameterColumns(EnterNum("Введите колличество столбцов: "));


double[,] arrayWithRealNumbers = arrayFilling(lines, columns);

PrintArray(arrayWithRealNumbers);
