// принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Жду число: ");
int num = int.Parse(Console.ReadLine () ?? "");
string weekday = "";

// Поверим что в числе не более одной цифры 
if (num <= 7 && num >=1) 
{
    if (num == 1 ) weekday = "Понедельник" ;
    if (num == 2 ) weekday = "Вторник" ;
    if (num == 3 ) weekday = "Среда" ;
    if (num == 4 ) weekday = "Четверг" ;
    if (num == 5 ) weekday = "Пятница" ;
    if (num == 6 ) weekday = "Суббота" ;
    if (num == 7 ) weekday = "Воскресенье" ;
    Console.WriteLine($"Получено число <{num}> - День недели: {weekday}");
}
else
{
    Console.WriteLine($"Полученое число <{num}> - неверно");
}
