// Вывести случаейное число из интервала 
Console.Clear();

int  num = new Random().Next(100,1000) ;
int a1 = num / 100 ; // Первая цифра это сотни, поэтому делим на 100
int a3 = num % 10 ; // Третья чифра это единицы, делим без остатка на 10

int result = a1*10 +a3 ; 

Console.WriteLine($"Двухзначное число  {num} -> {result}");