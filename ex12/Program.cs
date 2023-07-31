// Одидаем два числа
Console.WriteLine("Жду первое число");
int num1 = int.Parse(Console.ReadLine () ?? "");
Console.WriteLine("Жду второе число");
int num2 = int.Parse(Console.ReadLine () ?? "");

// Проверим кратность второго числа
int result = num1 % num2 ;


// В случае если число кратно, то результать деления без остатка будет ноль(0)
if (result == 0 ) 
    Console.WriteLine($"Да - Кратно  <{num1}><{num2}> -> {result}");
else 
    Console.WriteLine($"НЕТ  <{num1}><{num2}> -> {result}");



//  34, 5 -> не кратно, остаток 4 
//  16, 4 -> кратно
