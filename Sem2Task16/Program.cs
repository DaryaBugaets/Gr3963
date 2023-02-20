// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

void squareTest(int firstNum, int secondNum)
{
    if(firstNum == Math.Pow(secondNum,2))
    {
        Console.WriteLine($"Число {firstNum} является квадратом {secondNum}");
    }
    else
    {
        Console.WriteLine($"Число {firstNum} не является квадратом {secondNum}");
    }
}

Console.WriteLine("Введите первое число: ");
int firstNumer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumer = Convert.ToInt32(Console.ReadLine());

squareTest(firstNumer,secondNumer);

squareTest(secondNumer,firstNumer);


// Нарушение технического задания
// Console.WriteLine("введите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int quadro1 = Quadro(num1);
// int quadro2 = Quadro(num2);

// if (quadro1 == num2 || quadro2 == num1)
// {
// Console.Write("Да");
// }
// else 
// {
//   Console.Write("Нет");  
// }

// int Quadro (int a)
// {
//     return a * a;
// }

// Неполное решение
// Console.WriteLine("Введите 2 числа:");
// double num1 = Convert.ToDouble(Console.ReadLine());
// double num2 = Convert.ToDouble(Console.ReadLine());
// double square = Math.Pow(num1, 2);

// if (num2 == square)
// {
//     Console.WriteLine("Да, число {0} квадрат {1}", num2, num1);
// }
// else
// {
//     Console.WriteLine("Нет, число {0} не квадрат числа {1}", num2, num1);
// }

// Тоже непринято, решается сразу две задачи
// void IfSquared(int res1, int res2)
// {
//     if (res2 == res1 * res1)
//     {
//         Console.WriteLine($"{res2} - квадрат {res1}");
//     }
//     else
//     {
//         if (res1 == res2*res2)
//         {
//             Console.WriteLine($"{res1} - квадрат {res2}");
//         }
//     }
// }


// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()?? "0");
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()?? "0");

// IfSquared(num1, num2);


