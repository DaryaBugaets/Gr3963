// Вводим первое число
Console.WriteLine("Введите число №1: ");
int numA=Convert.ToInt32(Console.ReadLine());
// Вводим второе число
Console.WriteLine("Введите число №2: ");
int numB=Convert.ToInt32(Console.ReadLine());
// Вводим третье число
Console.WriteLine("Введите число №3: ");
int numC=Convert.ToInt32(Console.ReadLine());
// Сравниваем числа 1 и 2, если больше первое
if(numA>numB)
{
   if(numA>numC)
   {
    Console.WriteLine("Максимальное число №1");
   }
    else
    {
        Console.WriteLine("Максимальное число №3");
    }
// Сравниваю 1 и 2 числа, если 2 больше
}
else
{
    if(numB>numC)
    {
        Console.WriteLine("Максимальное число №2");
    }
    else
    {
        Console.WriteLine("Максимальное число №3");
    }
}