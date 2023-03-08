//  Задача №25
// Напишите цикл, который принимает на вход 2 числа a и b,
// и возводит число а, в натуральную степень b

//запрос данных у пользователя
// int ReadData(string msg)
// {
//     //выводим сообщение
//     Console.Write(msg);
//     // проверяем и возвращаем значение
//      return (int.Parse(Console.ReadLine() ?? "0"));
// }
// // Метод подсчета
// long Pow(int numA, int numB)
// {
//     long res = 1;
//     while (numB>0)
//     {
//         res=res*numA;
//         numB=numB-1;
//     }
//     return res;
// }
// int res1=ReadData("Введите число А: ");
// int res2=ReadData("Введите число B: ");
// Console.WriteLine (Pow (res1, res2));


// калькулятор *
using System.Collections.Generic;

double num1 = ReadDouble("Введите первое число: ");
double num2 = ReadDouble("Введите второе число: ");

Console.WriteLine("Выберите операцию: ");
Console.WriteLine("+ - сложение");
Console.WriteLine("- - вычитание");
Console.WriteLine("* - умножение");
Console.WriteLine("/ - деление");
Console.WriteLine("^ - возведение в степень");

string op = Console.ReadLine()?? "0";

Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>()
            {
                { "+", (a, b) => a + b },
                { "-", (a, b) => a - b },
                { "*", (a, b) => a * b },
                { "/", (a, b) => a / b },
                { "^", (a, b) => Math.Pow(a, b) }
            };

if (operations.TryGetValue(op, out Func<double, double, double> operation))
{
    double result = operation(num1, num2);
    Console.WriteLine("Результат: " + result);
}
else
{
    Console.WriteLine("Неправильный оператор");
}

static double ReadDouble(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine() ?? "0");
}