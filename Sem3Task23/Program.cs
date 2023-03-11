// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// * Вывести таблицу с границами и значениями друг над другом

// // метод читает данные от пользователя
// int ReadDate(string msg)
// {
//     Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }
// // построение таблицы
// string LineBuilder(int num, int cube)
// {
//     string res = String.Empty;
//     for(int i = 1; i<=num; i++)
//     {
//         res = res + Math.Pow (i, cube)+"\t";
//     }
//     return res;
// }

// int N = ReadDate("Введите конечное число: ");
// Console.WriteLine(LineBuilder(N,1));
// Console.WriteLine(LineBuilder(N,3));





// // *разбор
// // Функция для чтения ввода с консоли, принимает сообщение в качестве аргумента, выводит его и возвращает введенное число.
int ReadInput(string mess)
{
    Console.Write(mess);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
// Функция для построения таблицы значений и кубов чисел.
// Принимает на вход число end, которое определяет конечное число, до которого строится таблица.
void LineBuilder(int end)
{
    // Вывод верхней границы таблицы.
    Console.Write("┌───────────");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("┬───────────");
    }
    Console.WriteLine("┐");

    // Вывод заголовков столбцов.
    Console.Write("|     Value ");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("| {0,-10}", i);
    }
    Console.WriteLine("|");

    // Вывод разделительной линии между заголовками и значениями.
    Console.Write("├───────────");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("┼───────────");
    }
    Console.WriteLine("┤");

    // Вывод значений кубов чисел.
    Console.Write("|     Cube  ");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("| {0,-10}", i * i * i);
    }
    Console.WriteLine("|");

    // Вывод нижней границы таблицы.
    Console.Write("└───────────");
    for (int i = 1; i <= end; i++)
    {
        Console.Write("┴───────────");
    }
    Console.WriteLine("┘");
}

// Получение конечного числа от пользователя и построение таблицы.
int N = ReadInput("Введите конечное число: ");
LineBuilder(N);