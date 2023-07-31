// Задача 13: Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.WriteLine("Жду число: ");
int num = int.Parse(Console.ReadLine () ?? "");

// Поверим что в числе более двух знаков 
if (num < 100 ) 
{
    Console.WriteLine($"В числе <{num}> - третьей цифры нет");
}
else
{
    int bb = 100 ; 
    int numNum = 2 ;
    while (num / bb != 0)
    {
        Console.WriteLine($"Трехзначное число  {num} -><{num / bb}>  bb=<{bb}>");
        bb = bb * 10 ;
        numNum ++ ;
    }
    int result =  num / Convert.ToInt32(Math.Pow(10, (numNum - 3))) ;
    result = result % 10 ;
    Console.WriteLine($"Число разрядов {num} -> {result}");

}

//int a1 = num / 100 ; // Первая цифра это сотни, поэтому делим на 100
//int a2 = (num - a1*100) / 10 ; // Вторя цифра это десятки, поэтому вычитаем сотни и делим на 10
//int a3 = num % 10 ; // Третья чифра это единицы, делим без остатка на 10

//int result = a2 ;
//int result = a1*10 +a3 ; 

//Console.WriteLine($"Трехзначное число  {num} -> {result} a1=<{a1}> a2=<{a2}> a3=<{a3}>");

/*
Данные для проверки
        645 -> 5
        78 -> третьей цифры нет
        32679 -> 6
*/