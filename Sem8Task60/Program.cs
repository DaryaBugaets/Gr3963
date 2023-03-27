// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] Gen3DArray(int min, int max, int CountX, int CountY, int CountZ)
{
    int buf;
    int m = 0;
    int[] randomNum = new int[CountX * CountY * CountZ];
    int[,,] binarray = new int[CountX, CountY, CountZ];
    if (min > max)
    {
        buf = min;
        min = max;
        max = buf;
    }
    //вызов метода возвращающего массив неповторяющихся двузначных чисел 
    randomNum = GenRandomArray(randomNum.GetLength(0));

    for (int i = 0; i < CountX; i++)
    {
        for (int j = 0; j < CountY; j++)
        {
            for (int k = 0; k < CountZ; k++)
            {
                //заполняем массив
                binarray[i, j, k] = randomNum[m];
                m++;                
            }
        }
    }
    return binarray;
}
//сам метод генерации неповторяющихся двузначных чисел 
int[] GenRandomArray(int len)
{
    System.Random numSintezator = new System.Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        int r = numSintezator.Next(10, 100);
        if (!(arr.Contains(r)))
        {
            arr[i] = r;
        }
        else
        {
            i--;
        }
    }
    return arr;
}
// вывод массива на экран
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k})\t");
            }
        }
    }

}
//генерируем наш массив
int[,,] array1 = Gen3DArray(1, 10, 2, 2, 2);
//выводим массив
Console.WriteLine("Исходный массив:");
Print3DArray(array1);
Console.WriteLine();
