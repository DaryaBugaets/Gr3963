// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//Принимаем из консоли число
int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Выводит в консоль сообщение
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int RecSumDigMN(int m, int n)
{
    int res = 0;

    if (m > n) return res;
    else
    {   
        res += m + RecSumDigMN(m + 1, n);
        return res;
    }
}

int num1 = ReadData("Введите 1 границу промежутка: ");
int num2 = ReadData("Введите 2 границу промежутка: ");
if (num1 > num2) (num1, num2) = (num2, num1);

PrintData($"Сумма = {RecSumDigMN(num1, num2)}");