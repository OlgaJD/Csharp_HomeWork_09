// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите минимальное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int NaturalNumbers(int m, int n)
{
    if (m == n) return n;
    Console.Write(m + ", ");
    return NaturalNumbers(m + 1 , n);

}
if (m>n)Console.WriteLine("Вводите только целые числа. Первое чиcло должно быть меньше второго.");
if (m<n)Console.WriteLine(NaturalNumbers(m,n));
