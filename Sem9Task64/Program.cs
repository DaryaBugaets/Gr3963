// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 3, 4"
// N = 8 -> "1, 2, 3, 4, 5, 6, 7, 8"

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


//Создёт строку в которой все натуральные числа в промежутке от 1 до N
string LineGenRec(int n, int number)
{
    string res = String.Empty;

    if (number <= n)
    {
        res += number + " " + LineGenRec(n, number + 1);
        return res;
    }
    else
    {
        return res;
    }
}

int num = ReadData("Введите до какого числа выводить последовательность: ");
PrintData($"{LineGenRec(num, 1)}");