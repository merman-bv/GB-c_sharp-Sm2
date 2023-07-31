// Одидаем два числа
Console.WriteLine("Жду первое число");
int num1 = int.Parse(Console.ReadLine () ?? "");
Console.WriteLine("Жду второе число");
int num2 = int.Parse(Console.ReadLine () ?? "");

// Найдейм квадраты числе
int a = num1 * num1 ;
int b = num2 * num2 ;

// проверим квадраты чисел

if (num1 == b)
    Console.WriteLine($"Первое число <{num1}> квадрат вторго <{num2}>");
else if (num2 == a)
    Console.WriteLine($"Второе число <{num2}> квадрат первого <{num1}>");
else 
    Console.WriteLine($"Числа <{num1}> и <{num2}> не являются двадратом другого");

/* 
Тестовые данные
    5, 25  ->  да
    -4, 16  ->  да
    25, 5  ->  да
    8,9  ->  нет
*/