// Задача №6
// Напишите программу, 
// которая на вход принимает число и выдает, является ли число четным
// Ввод числа
Console.WriteLine("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
// Проверка условия
if(num%2==0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}