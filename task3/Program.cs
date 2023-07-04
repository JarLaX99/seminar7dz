// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void main()
{
    int row = ReadInt("Введите кол-во строк массива : ");
    int col = ReadInt("Введите кол-во столбцов массива : ");
    int[,] matrix = FullArray(row, col);
    PrintMatrix(matrix);
    double[] result = ArithmeticMeanOfTheColumn(matrix);
    PrintArray(result);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FullArray(int row = 5, int col = 5, int leftRange = 1, int rightRange = 50)
{
    int[,] tempMatrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrix)
{
       for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j]+ "\t");
        }
        System.Console.WriteLine();
    }
}

double[] ArithmeticMeanOfTheColumn(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum+=matrix[i,j];
        }
        array[j]= Math.Round(sum/matrix.GetLength(0),2);
        sum=0;
    }
    return array;
}

void PrintArray(double[] arrayForPrint)
{   
    System.Console.WriteLine();
    System.Console.WriteLine(string.Join("\t", arrayForPrint));
}

main();