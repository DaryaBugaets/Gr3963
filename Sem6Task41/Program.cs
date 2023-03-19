// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// *Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.


// // Вариант 1
// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");



// // Вариант2
// Пользователь вводит данные
int ReadData(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод, выводящий на печать данные
void PrintData(string msg)
{
    Console.Write(msg);
}
int CountNum(int NumM)
{
    int res = 0;
    for (int i = 0; i < NumM; i++)
    {
        if (ReadData(" ") > 0)
        {
            res++;
        }
    }
    return res;
}
int num= ReadData("Введите нужное количество чисел, а затем перечислите их, каждое с новой строки: ");
int res = CountNum(num);
PrintData($"Из {num} чисел, было введено: {res.ToString()} больше 0");
