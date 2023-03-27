// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Принимаем из консоли число
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными числами
int[,] Gen2DArrSpirally(int countRow, int CountCol)
{
    int[,] res = new int[countRow, CountCol];

    int num = 1;
    int row = 0;
    int col = 0;
    while (num <= res.Length)
    {
        // заполнение верхней строки(слева направо)
        for (int i = col; i < countRow - col; i++)
        {
            res[row, i] = num;
            num++;
        }
        // заполнение правого столбца(сверху вниз)
        for (int i = row + 1; i < countRow - row; i++)
        {
            res[i, countRow - col - 1] = num;
            num++;
        }
        // заполнение нижней строки(справа налево)
        for (int i = countRow - col - 2; i >= col; i--)
        {
            res[countRow - row - 1, i] = num;
            num++;
        }
        // заполнение левого столбца(снизу вверх)
        for (int i = countRow - row - 2; i > row; i--)
        {
            res[i, col] = num;
            num++;
        }
        // переход к следующему кругу спирали
        row++;
        col++;
    }
return res;
}

// выводим двумерный массив на экран 
void Print2DArrSpirally(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}
int rowAndColum = ReadData("Введите количество строк и столбцов в массиве: ");
int[,] matrix = Gen2DArrSpirally(rowAndColum, rowAndColum);
Console.WriteLine("Массив:");
Print2DArrSpirally(matrix);