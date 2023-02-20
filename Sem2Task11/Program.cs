// Задача №11
// Напишите программу, 
// которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Вариант 1
Random rnd = new Random();

int rndNum = rnd.Next(100, 1000);
Console.WriteLine($"Рандомное число = {rndNum}");

int lastDigit = rndNum % 10;
int firstDigit = rndNum / 100;
rndNum = firstDigit * 10 + lastDigit;
Console.WriteLine($"Получившееся число = {rndNum}");

// Вариант 2
// System.Random numSintezator = new System.Random();

// int num = new Random().Next(100,1000);
// Console.WriteLine(num);

// int lastDigit = num%10;
// int firstDigit = num/100;
// num = firstDigit*10 + lastDigit;
// Console.WriteLine(num);

// // Вариант 3
// System.Random numSintezator = new System.Random();
// int rndNumber = numSintezator.Next(100,1000);
// Console.WriteLine(rndNumber);

// char [] digits1 = rndNumber.ToString().ToCharArray();

// Console.WriteLine(int.Parse((digits1[0]).ToString())*10+int.Parse((digits1[2]).ToString()));

// // Вариант 4
// int num = new Random().Next(100, 1000);
// Console.WriteLine("Случайное число - " + num);

// int lastDigit = num % 10;
// int firstDigit = num / 100;

// num = firstDigit * 10 + lastDigit;

// Console.WriteLine("Результат работы - " + num);