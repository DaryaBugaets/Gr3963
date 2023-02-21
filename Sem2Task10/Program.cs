// Задача №10
// Напишите программу, которая принимает на вход 3-х значное число, 
// и на выходе показывает 2-ю цифру этого числа
Console.WriteLine ("Введите число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
int num2 = ((num1/10) %10);
if((100<=num1) && (num1<1000))
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine("Это не трехзначное число");
}


// Из примера
// int Prompt(string massage)
// {
//     System.Console.Write(massage);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int number = Prompt("Введите трехзначное число> ");
// if(number < 100 || number >= 1000)
// {
//     Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
//     return;
// }
// Console.WriteLine($"Введенное число `{number}`");
// int secondRank = number/10 % 10;
// Console.WriteLine($"Вторая цифра `{secondRank}`");
