// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int[,] newMatrix = RandomArray(5, 4);
PrintArray(newMatrix);
Console.WriteLine();
int[] sumArray = MinimalSum(newMatrix);
Console.WriteLine(MinimalNumberPosition(sumArray));

int MinimalNumberPosition(int[] array)
{
    int minNumber = array[0];
    int minPosition = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minNumber) 
        {
            minNumber = array[i];
            minPosition = i;
        }
    }
    return minPosition;
}

int[] MinimalSum(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

int[,] RandomArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random randGenerator = new Random();
    for (int i = 0; i < m; i++) for (int j = 0; j < n; j++) newArray[i, j] = randGenerator.Next(0, 10);
    return newArray;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++) Console.Write($"{newArray[i, j]} ");
        Console.WriteLine("");
    }
}