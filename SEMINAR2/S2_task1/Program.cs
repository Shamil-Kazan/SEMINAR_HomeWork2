// See https://aka.ms/new-console-template for more information
void Output2(int num)
{   
    int num2 = (num/10)%10;
    Console.WriteLine("второе число  " + num2);
}
    Console.WriteLine("Введите трехзначное число");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num<=99 || num>999)  //если пользователь введет ошибочно не трехзначное число.
        Console.WriteLine("ERROR");
    else
    {
        Output2(num);
    }
    
