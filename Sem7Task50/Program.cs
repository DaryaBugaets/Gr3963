// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// *Заполнить числами Фиббоначи и выделить цветом найденную цифру

// Вариант1
// Console.WriteLine("Введите количество строк массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int[m, n];


 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array [i, j] = Convert.ToInt32(new Random().Next(0,99));  
// }
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + "\t  ");
//         Console.WriteLine();
// }
 
//  Console.WriteLine("Введите номер позиции элемента:");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m && b>n)
//  Console.WriteLine("такого числа нет");
//  else
//  {
//  object c = array.GetValue(a,b);
//  Console.WriteLine(c);
//  }


// // Вариант2
//метод читает данные от пользователя
int  ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}
//метод генерации массива
int[,] Gen2DArr(int Row,int Coloumn,int min,int max)
{
    
    int[,] arr=new int[Row,Coloumn];
    for(int i=0;i<Row;i++)
    {
        for(int j=0;j<Coloumn;j++)
        {
            arr[i,j]=new Random().Next(min,max+1);
        }
    }
    return arr;
} 

void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.DarkRed};
    for(int i=0; i<arr.GetLength(0);i++)
    {
        for(int j=0; j<arr.GetLength(1);j++)
        {
            Console.ForegroundColor=col[new Random().Next(0,3)];
            Console.Write(arr[i,j]+"\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    } 
}
void Print2DArrNum(int[,]arr,int row, int col)
{
    if(arr.GetLength(0)>row&&arr.GetLength(1)>col)
    {
        Console.WriteLine(arr[row,col]);
    }
    else
    {
        Console.WriteLine("Такого элемента нет!");
    }
}
int index1 = ReadData("Введите номер строки массива: ");
int index2 = ReadData("Введите номер столбца массива: ");
int [,] array2D = Gen2DArr (10, 10, 10, 99);
Print2DArr(array2D);
Print2DArrNum(array2D, index1, index2);





