// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] Gen2DArray(int min, int max, int CountRow, int CountCol)
{
    int buf;
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    int[,] binarray = new int[CountRow, CountCol];
    System.Random numSintezator = new System.Random();
    for (int i = 0; i < CountRow; i++)
    {
        for (int j = 0; j < CountCol; j++)
        {

            binarray[i, j] = numSintezator.Next(min, max);

        }
    }
    return binarray;
}

// метод умножения двух матриц
int[,] MultiArray(int[,] array1, int[,] array2)
{
    if ((array1.GetLength(0) != array2.GetLength(0)) || (array1.GetLength(1) != array2.GetLength(1)))
    {
        throw new Exception("Для матриц с разным размером сложение невозможно!");
    }

    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];

    for (var i = 0; i < array1.GetLength(0); i++)
    {
        for (var j = 0; j < array2.GetLength(0); j++)
        {
            array3[i, j] = 0;

            for (var k = 0; k < array1.GetLength(1); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }

        }
    }

    return array3;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write($"{array[i, j]}\t");

        }
        Console.WriteLine();
    }

}
//генерируем наш массив
int[,] array1 = Gen2DArray(1, 10, 3, 3);
int[,] array2 = Gen2DArray(1, 10, 3, 3);
//выводим массив
Console.WriteLine("Исходные массивы:");
Print2DArray(array1);
Console.WriteLine();
Print2DArray(array2);
Console.WriteLine();
//умножаем матрицы
int[,] multiMatrix = MultiArray(array1, array2);
Console.WriteLine("Результирующая матрица:");
//выводим результат
Print2DArray(multiMatrix);