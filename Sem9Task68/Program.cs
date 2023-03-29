// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Аккерман =A(n,m)


int ReadData(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

int ARec(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return ARec(m - 1, 1);
    }
    else
    {
        return ARec(m - 1, ARec(m, n - 1));
    }
}

int num1 = ReadData("Введите 1 неотрицательное число: ");
int num2 = ReadData("Введите 2 неотрицательное число: ");

if (num1 < 0 || num2 < 0) PrintData("Ошибка. Введите 2 неотрицательных числа");
else PrintData($"A({num1},{num2}) = {ARec(num1,num2)}");