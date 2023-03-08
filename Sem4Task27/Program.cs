// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// *Сделать оценку времени алгоритма через числа и строки

//  Задача №24
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//запрос данных у пользователя
int ReadData(string msg)
{
    //выводим сообщение
    Console.Write(msg);
    //считываем число
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num; //возвращаем значение
}

// Метод вывода результата
// void PrintResult(string num)
// {
//     Console.WriteLine(num);
// }

// складываем цифры в числе
int SumDigits(int num)
{
    int advance = 0;
    int res = 0;
    
    for (int i = 0; i <= num; i++)
    {
        advance=num-num % 10;
        res=res+(num-advance);
        num=num/10;
    }
    return res;
}
int num = ReadData("Введите число: ");
Console.WriteLine (SumDigits (num));
// PrintResult("Сумма цифр в числе:" + res);



// (*)
// using System.Diagnostics;

//         Console.Write("Введите число: ");
//         string input = Console.ReadLine();

//         // Используем цифровой алгоритм
//         Stopwatch stopwatch1 = Stopwatch.StartNew();
//         int sum1 = 0;
//         int number1 = int.Parse(input);
//         while (number1 != 0)
//         {
//             sum1 += number1 % 10;
//             number1 /= 10;
//         }
//         stopwatch1.Stop();

//         // Используем строчный алгоритм
//         Stopwatch stopwatch2 = Stopwatch.StartNew();
//         int sum2 = 0;
//         char[] digits = input.ToCharArray();
//         foreach (char digit in digits)
//         {
//             sum2 += int.Parse(digit.ToString());
//         }
//         stopwatch2.Stop();

//         // Выводим результаты
//         Console.WriteLine("Сумма цифр в числе (цифровой алгоритм): " + sum1);
//         Console.WriteLine("Время выполнения (цифровой алгоритм): " + stopwatch1.Elapsed);
//         Console.WriteLine();
//         Console.WriteLine("Сумма цифр в числе (строчный алгоритм): " + sum2);
//         Console.WriteLine("Время выполнения (строчный алгоритм): " + stopwatch2.Elapsed);