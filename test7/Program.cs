// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите число: ");

int numb = Convert.ToInt32(Console.ReadLine());

if(numb > 5 && numb < 8)

Console.WriteLine ("Выходной день " + numb);

else if(numb < 6 && numb > 0)

Console.WriteLine ("Будний день " + numb);

else

Console.WriteLine ("не верное число " + numb);
