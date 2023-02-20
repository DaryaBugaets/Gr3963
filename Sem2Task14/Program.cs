// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine()??"0");
// if(num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }


//  Console.WriteLine("Введите число: ");
// int Number = int.Parse(Console.ReadLine()??"0");


// int rem23 = Number%23;
// int rem7 = Number%7;

// if(rem23 == 0 && rem7 == 0)
// {
//     Console.WriteLine("Кратно");
// }else{
//     Console.WriteLine("Не кратно");
// }


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine($"Число {num} кратно 23 и 7");
}
else
{
    Console.WriteLine($"Число {num} не кратно 23 и 7");   
}

// нет проверки на null
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Число кратно 7 и 23.");
// }
// else
// {
//     Console.WriteLine("Число не кратно 7 и 23.");
// }

// Console.WriteLine("Введите любое число");
// int Num1 = int.Parse(Console.ReadLine()??"0");

// if ((Num1%7 == 0) && (Num1%23 == 0))
// {
//     Console.WriteLine("Делится");
// }
// else
// {
//     Console.WriteLine("Не делится");
// }

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()??"0");
int rem1 = Number%23;
int rem2 = Number%7;
string? result = (rem1 == 0 && rem2 == 0)? "кратно":"не кратно";
Console.WriteLine(result);