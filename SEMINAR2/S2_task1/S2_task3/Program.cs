// See https://aka.ms/new-console-template for more information
void WeekDay()
{
Console.WriteLine("Введите число");
int day = new Random().Next(1, 7);
if(day==6 || day==7)
{
    Console.WriteLine("Да " + day);
}
else
{
    Console.WriteLine("Нет " + day);
}
}
WeekDay();

