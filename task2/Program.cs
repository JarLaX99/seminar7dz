// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void main()
{
    int[,] matrix = FullArray(6, 6);
    PrintMatrix(matrix);
    System.Console.WriteLine();
    NumberSearch(matrix);
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void NumberSearch(int[,] matrix)
{
    int row = ReadInt("Введите номер строчки: ");
    int col = ReadInt("Введите номер столбца: ");
    if (row < matrix.GetLength(0) && col < matrix.GetLength(1))
    {
        System.Console.Write($"под этим индексом находится число {matrix[row, col]}");
    }
    else
    {
        System.Console.WriteLine($"{row},{col} вы вышли за пределы массива, такого индекса в массиве нет");
    }
}
main();