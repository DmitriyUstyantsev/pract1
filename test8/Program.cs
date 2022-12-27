// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите число для проверки на полиндром : ");
 int number = int.Parse(Console.ReadLine());
            int i, sum = 0;
            int temp = number;
            while (number > 0)
            {
              
                i = number % 10;
             
                sum = (sum * 10) + i;
             
                number = number / 10; 
            }
            if (temp == sum)
            
Console.WriteLine($"Число {temp} палиндром.");

else

Console.WriteLine($"Число {temp} не палиндром");

