// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["Привет", "2", "мир", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "информатика"] → ["-2"]
// [«Россия», «Дания», «Казань»] → []

Console.WriteLine("Нужно указать количество строк");
целое  число  =  целое . Разобрать ( Console.ReadLine ( ) ! ) ;
string [] arr  =  UserFillArray ( num );
Консоль . НаписатьСтроку ();
РаспечататьМассив ( обр );
Консоль . НаписатьСтроку ();
int  count  =  CountStringsNewArray ( arr );
если ( количество  >  0 )
{
    string [] arrNew  =  FillArrayNew ( arr , count );
    РаспечататьМассив ( АррНовый );
}
else Console.WriteLine("Строк нет, длина которых меньше либо равна 3 символам");
строка [] UserFillArray ( целое  число )
{
    строка [] массив  =  новая  строка [ число ];
    for ( int  i  =  0 ; i  <  array . Length ; i ++ )
    {
        Console.WriteLine("Введите строку");
        массив [ i ] =  консоль . РидЛайн () ! ;
    }
    возвращаемый  массив ;

}
void  PrintArray ( строка [] массив )
{
    for ( int  i  =  0 ; i  <  array . Length ; i ++ )
    {
        Консоль . Напишите ( $" { массив [ i ]} " );
    }
}

int  CountStringsNewArray ( строка [] массив )
{
    Целый  счетчик  =  0 ;
    for ( int  i  =  0 ; i  <  array . Length ; i ++ )
    {
        если ( массив [ i ]. Длина  <  4 ) счетчик ++ ;
    }
    обратный  счетчик ;
}

строка [] FillArrayNew ( строка [] массив , счетчик int  )
{
    строка [] arrayNew  =  новая  строка [ счетчик ];
    интервал  j  =  0 ;
    for ( int  i  =  0 ; i  <  array . Length ; i ++ )
    {
        если ( массив [ i ]. Длина  <  4 )
        {
            arrayNew [ j ] =  массив [ i ];
            я ++ ;
        }
    }
    вернуть  новый массив ;
}