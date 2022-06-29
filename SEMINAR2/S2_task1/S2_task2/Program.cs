// See https://aka.ms/new-console-template for more information
void ThirdNum()
{   Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 100)
    {   
        Console.WriteLine("третьей цифры нет");
    }
    else {
        while (num>999)
    {
             num=num/10;
    }
    int num3 = num %10;
    Console.WriteLine(num3);    
    }
}

ThirdNum();
