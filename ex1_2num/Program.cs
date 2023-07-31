//  Принять два числа
Console.WriteLine("Жду первое число: ");
int num1 = int.Parse(Console.ReadLine () ?? "");
Console.WriteLine("Жду второе число: ");
int num2 = int.Parse(Console.ReadLine () ?? "");
// Проверим что первое квадрат второго
if (num1 == num2*num2)
{
   Console.WriteLine($"Да первое число: {num1} есть квадрат второго: {num2}"); 
} 
else
{
    Console.WriteLine($"Нет первое число: {num1} не квадрат второго: {num2}"); 
}