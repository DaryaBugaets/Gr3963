// Задача 15
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

// Console.Write("Введите день недели-");
// int num = int.Parse(Console.ReadLine()??"0");
// if(num>5 && num<8)
// {
//     Console.WriteLine("Это выходной день");
// }
// else
// if(num>0 && num<6)
// {
//     Console.WriteLine("Это будний день");
// }
// else
// {
//     Console.WriteLine("Это не день недели");
// }



// *
Dictionary<int, string> daysOfWeek = new Dictionary<int, string>();

// Добавляем дни недели в словарь
daysOfWeek.Add (1, "Понедельник-будний день");
daysOfWeek.Add (2, "Вторник-будний день");
daysOfWeek.Add (3, "Среда-будний день");
daysOfWeek.Add (4, "Четверг-будний день");
daysOfWeek.Add (5, "Пятница-будний день");
daysOfWeek.Add (6, "Суббота-выходной день");
daysOfWeek.Add (7, "Воскресенье-выходной день");
// Просим ввести день недели
Console.Write("Введите день недели-");
int dayOfWeek=int.Parse(Console.ReadLine()??"0");
if(daysOfWeek.ConstainsKey(dayOfWeek))
{
    Console.WriteLine(daysOfWeek[dayOfWeek]);
}
else
{
    Console.WriteLine("Это не день недели");
}

// выдает сразу все???
// Console.Write("Введите день недели-");
// var Week = new Dictionary<string, string>();
// Week.Add ("1", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.Add ("2", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.Add ("3", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.Add ("4", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.Add ("5", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.Add ("6", "выходной день");
// Console.WriteLine("Это выходной день");
// Week.Add ("7", "выходной день");
// Console.WriteLine("Это выходной день");


// Console.Write("Введите день недели-");
// var Week = new Dictionary<string, string>();
// Week.TryAdd ("1", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.TryAdd ("2", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.TryAdd ("3", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.TryAdd ("4", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.TryAdd ("5", "рабочий день");
// Console.WriteLine("Это будний день");
// Week.TryAdd ("6", "выходной день");
// Console.WriteLine("Это выходной день");
// Week.TryAdd ("7", "выходной день");
// Console.WriteLine("Это выходной день");