/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
* Найдите все пары в массиве и выведите пользователю
*/

int[] Gen1DArray(int len, int min, int max)
{
    // Блок корректировки входных данных 
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
void PrintData( string sum)
{
    Console.WriteLine(sum);
}
void Print1DArray(int[]arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");    
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}

int[] OddSum (int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i=i+2)   
    {
        sum = sum + arr[i];
    }
    return sum;
}

// // находим все пары элементов массива и выводим на экран


int[] testArr = Gen1DArray(13, 1, 9);
Print1DArray(testArr);
int[] sum = OddSum (testArr);
PrintData(sum.ToString());


// void PairsInAnArray(int[]array);
// for (int i = 0; i < arr.Length; i++)
// {
//     for (int j = i + 1; j < arr.Length; j++)
//     {
//         Console.Write(arr[i] + " " + arr[j]);
//     }

// }
