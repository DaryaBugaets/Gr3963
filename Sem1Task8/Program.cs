// Задача №8
// Напишите программу,
// котрая на вход принимает, число N, а на выходе показывает все четные числа от 1 до N
// Вводим число
Console.WriteLine("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());
// Выполняем условие
for (int i = 2; i < numN; i=i+2)
{
    Console.Write(i + "  ");
}