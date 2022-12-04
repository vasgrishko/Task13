// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (num >= 100)
{    
    while (num > 999)
    {
        num = num / 10;
    }
    result = num % 10;
    Console.WriteLine(result);
    }
else
{
    Console.WriteLine("Третьей цифры нет");
}


    
   
   
    


    
