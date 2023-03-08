// Задача 29: Напишите программу, которая задаёт массив из N элементов
// и выводит их на экран. Ввести с клавиатуры длину массива и диапазон значений элементов.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// *Дополнительно: Написать программу которая из имен через запятую 
// выберет случайное имя и выведет в терминал Игорь, Антон, Сергей -> Антон 
// Подсказка: Для разбора строки использовать метод string.split(). 
// Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

// // Вариант 1
// // Запрашиваем у пользователя длину массива и диапазон значений элементов
// Console.Write("Введите длину массива: ");
// int len = int.Parse(Console.ReadLine()?? "0");

// Console.Write("Введите минимальное значение элемента: ");
// int minValue = int.Parse(Console.ReadLine()?? "0");

// Console.Write("Введите максимальное значение элемента: ");
// int maxValue = int.Parse(Console.ReadLine()?? "0");

// // Создаем массив со случайными значениями в заданном диапазоне
// int[] array = new int[len];
// Random random = new Random();
// for (int i = 0; i < len; i++)
// {
//     array[i] = random.Next(minValue, maxValue + 1);
// }

// Console.WriteLine ("Массив из " + len + " элементов со значениями от " + minValue + " до " + maxValue + ":");
// foreach (int element in array)

// {
//       Console.Write(element + " ");
// }



// Вариант 2
// Запрашиваем у пользователя длину массива и диапазон значений элементов
Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите минимальное значение элемента: ");
int minValue = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите максимальное значение элемента: ");
int maxValue = int.Parse(Console.ReadLine()?? "0");

// Создаем массив со случайными значениями в заданном диапазоне
int[] array = new int[len];
Random random = new Random();
for (int i = 0; i < len; i++)
{
    array[i] = random.Next(minValue, maxValue + 1);
}

void PrintArr(int[]array)
{
    Console.Write("[");
    for (int i = 0; i < len-1; i++)
    {
        Console.Write(array[i]+ ", ");
    }
    Console.Write(array[len-1]+"]");
}
PrintArr(array);







