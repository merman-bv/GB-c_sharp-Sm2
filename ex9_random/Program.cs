﻿// Случайное число из отреза
Console.Clear();

int  num = new Random().Next(10,100) ;
int a1 = num / 10 ;
int a2 = num % 10 ;
int max = a1 ;
if ( max < a2 ) max = a2 ;

Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");

// Тестовые данные
//  78 -> 8 
//  12-> 2 
//  85 -> 8