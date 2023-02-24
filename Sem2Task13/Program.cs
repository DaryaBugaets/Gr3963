// Задача 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// * Сделать вариант для числа длиной до 10 цифр не используя char или string

Console.Write ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num);
if (num2.Length > 2)
{
  Console.WriteLine("Третья цифра:" + num2[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}

