// Задача 54
// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void Gen2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Sort2DArray(int[,]matr)
{
    int[]row=new int[matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           row[j] = matr[i,j];
        }
        row=BubbleSort(row);
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr[i, j]=row[j]; 
        }
    }
}
void BubbleSort(int[] mas)
{
    int temp;
    for(int i=0; i<mas.Length;i++)
    {
        for (int j = 0; j < mas.Length; j++)
        {
            if(mas[i]>mas[j])
            {
                temp=mas[i];
                mas[i]=mas[j];
                mas[j]=temp;
            }
        }
    }
    return;
}
int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] matrix = new int[10,10];
Gen2DArray(matrix, 1, 100);
Print2DArray(matrix);
Sort2DArray(matrix);
Print2DArray(matrix);
