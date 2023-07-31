// Одидаем число
Console.WriteLine("Жду целое число");
int numNum = int.Parse(Console.ReadLine () ?? "");

// Проверим кратность второго числа
int a = 7;
int b = 23;

//int result = (numNum % a) + (numNum % b) ;


// В случае если число кратно, то результать деления без остатка будет ноль(0)
//if (result == 0 )
if (numNum % a == 0 && numNum % b == 0) 
    Console.WriteLine($"Да - Кратно  <{a}> и <{b}>");
else 
    Console.WriteLine($"НЕТ  <{a}> и <{b}>");

/*
Тестовые данные
    14 -> нет 
    46 -> нет 
    161 -> да
*/