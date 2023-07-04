// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int randomNumbers(int min, int max)
{
    Random rnd = new Random();
    int num = rnd.Next(min, max);
    return num;
}

int[,] arrayFilling(int lines, int columns)
{
    int[,] myArray = new int[lines, columns];

    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = randomNumbers(-10, 10);
        }
    }
    return myArray;
}

void Print2DArray(int[,] array)
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

void PrintArray(int[] array)
{


    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < 0)
        {
            System.Console.Write($"{array[j]}\t");
        }
        else
        {
            System.Console.Write($" {array[j]}\t");
        }
    }
    System.Console.WriteLine();
}



int[] sumOfColumns(int[,] myArray)
{
    int[,] array = myArray;
    int size = array.GetLength(1);

    int[] columnSums = new int[size];

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
        columnSums[i] = sum;
    }
    return columnSums;
}

int[] ArithmeticMeanOfColumns(int[] array)
{
    int[] ArithmeticMeanOfColumn = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        ArithmeticMeanOfColumn[i] = array[i] / array.Length;
    }
    return ArithmeticMeanOfColumn;
}

int[,] myArray = arrayFilling(randomNumbers(2, 10), randomNumbers(2, 10));
int[] myArgs = sumOfColumns(myArray);

Print2DArray(myArray);

System.Console.WriteLine();

int[] ArithmeticMean = ArithmeticMeanOfColumns(myArgs);

PrintArray(ArithmeticMean);