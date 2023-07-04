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
int[,] arrayfil = arrayFilling(randomNumbers(2, 10), randomNumbers(2, 10));

int [] colsum = sumOfColumns(arrayfil);

for (int i = 0; i < colsum.Length; i++)
{
    System.Console.WriteLine(colsum[i]);
}
