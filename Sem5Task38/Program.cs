// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Отсортируйте массив методом вставки

double [] Gen1DArray(int len, int min, int max)
{
    // Блок корректировки входных данных 
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    double[] arr = new double[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1)+new Random().NextDouble();
    }
    return arr;
}
void Print1DArray(double[]arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");    
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}
// сортировка методом "пузырька"
void BobbleSort(double[]arr)
{
    for(int i=0; i<arr.Length; i++)
        for(int j=0; j<arr.Length-i-1; j++)
        {
            if(arr[j]>arr[j+1])
            {
                double buf=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=buf;
            }
        }
}
double[] testArr = Gen1DArray(13, 1, 10);
Print1DArray(testArr);
BobbleSort(testArr);
Print1DArray(testArr);
Console.WriteLine(testArr[testArr.Length-1]-testArr[0]);