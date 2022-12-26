//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a,b,c,Mmax;

Console.WriteLine("Введите три числа: ");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());


if (a>b)

Mmax = a;

else

Mmax = b;

if (b>c)

Mmax = b;

else

Mmax = c;

if (c>a)

Mmax = c;

else

Mmax = a;

Console.WriteLine("{0} наибольшее число", Mmax);