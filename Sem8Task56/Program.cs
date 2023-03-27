// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
//считаем суммы строк и записываем в новый массив
int[] SumOfNumInAString(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    return sum;
}
// ищем индекс наименьшей суммы
int MinRowCount(int[] array)
{
    int index = 0;
    int min = array[0];
    for (var i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            index = i;
        }
    }
    return index;
}
// печать массива
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
int[,] array = Gen2DArray(10, 100, 7, 5);
//выводим массив
Console.WriteLine("Исходный массив:");
Print2DArray(array);
Console.WriteLine();
//считаем суммы в строках
int[] sumrow = SumOfNumInAString(array);
//возвращает индекс минимальной суммы
int index = MinRowCount (sumrow);
//выводим результат
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index} строка");