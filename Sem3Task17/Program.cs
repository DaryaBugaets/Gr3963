// Задача №17
// Напишите программу, которая принимает точки ввода координат (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти назад, в котором находится эта точка.

// <тип> <имя метода>(<тип> <название устанавливает>)
// {
//      возвращаем <тип>
// }

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0"); 
}
// Метод определить четверть по координатам точки
void  PrintQuterTest (int  x ,int  y )
{
    if( x  >  0  &&  y  >  0 ) Console.WriteLine ( " Точка в 1 четверти " );
    if( x  >  0  &&  y  <  0 ) Console.WriteLine ( " Точка во 2 четверти " );
    if( x  <  0  &&  y  <  0 ) Console.WriteLine ( " Точка в 3 четверти " );
    if( x  <  0  &&  y  >  0 ) Console.WriteLine ( " Точка в 4 четверти " );
}
int  coordX  =  ReadData( " Введите координату X: ");
int  coordY  =  ReadData( " Введите координату Y: ");
PrintQuterTest(coordX ,coordY );