// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * Сделать вариант через СЛОВАРЬ четырехзначных палиндромов

// метод для запроса данных у пользователя
int ReadDate(string msg)
// метод выводит строку, для введения данных
// проверяем число
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
// создаем метод на true/false
bool PalinTest(int num)
{
    bool res=false;
    if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num / 10) % 10))
    {
        res= true;
    }
    return res;
}
// вставляем в наш метод число, введенное пользователем
int num = ReadDate("Введите пятизначное число: ");
// кладем в переменную результат теста
bool resultTest = PalinTest(num);
if(resultTest==true)
{
    Console.WriteLine("Это число является палиндромом");
}
else
{
    Console.WriteLine("Это число не палиндром");
}




// неудачно
// int ReadDate(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }
// bool PalinTest(int num)
// {
//     return true;
// }
// bool resultPolinTest=PalinTest(int num)

// if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num / 10) % 10))
// {
//     Console.WriteLine("Это число является палиндромом");
//     res=true; 
    
// }
// else
// {
//     Console.WriteLine("Это число не палиндром");
// }
// return; 

// int res = ReadDate("Введите пятизначное число: ");


// int ReadDate(string msg)
// {
//     Console.WriteLine(msg);
//     return Convert.ToInt32(Console.ReadLine() ?? "0");
// }
// bool PalinTest(int num);
// {
//     bool res=true;
//     return; 
// }
// bool resultTest=PalinTest(int num);
// {
//     if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num / 10) % 10))
//     {
//         Console.WriteLine("Это число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Это число не палиндром");
//     }
// }
// int res = ReadDate("Введите пятизначное число: ");
