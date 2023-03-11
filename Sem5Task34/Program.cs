// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// * Отсортировать массив методом пузырька
// * Отсортируйте массив методом подсчета
// * Сравнить скорость работы метода пузырька и вставки

int[] Gen1DArray(int len, int min, int max)
{
    // Блок корректировки входных данных (Input data correction block)
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
// метод, выводящий на печать данные пользователю (method that prints data to the user)
void PrintData(string res)
{
    Console.WriteLine(res);
}

// метод, выводящий на печать массив (method that prints an array)
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine("]");
}

// метод, поиска четных чисел в массиве (method, search for even numbers in an array)
int EvenNum(int[]  inputArray)
{
    // переменная накопления результата
    int result = 0;
    // буфферная переменная
    int i=0;
    // пробегаем все элементы массива
    while (i<inputArray.Length-1)
    {
        // сверяем элемент
        if (inputArray[i] %2 == 0)
        {
            // подсчитаем результат
            result++; 
        }
        i++;
    }
    return result;
}
int[] testArr = Gen1DArray(12, 100, 999);
Print1DArray(testArr);
int result = EvenNum(testArr);
PrintData (result.ToString());
