// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int ElementsSum(int m, int n)
// {
//     int sum = 0;
//     while (n > m - 1)
//     {
//         sum += n;
//         n--;
//     }
//     return sum;
// }

Console.Write("Введите число-начало промежутка: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число-окончание промежутка: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (m > n) Console.WriteLine("Введите два целых числа. Первое число должно быть меньше второго");
else ElementsSum(m, n, sum);

void ElementsSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма чисел в указанном промежутке: {sum}");
        return;
    }
    sum = sum + (m++);
    ElementsSum(m, n, sum);
}



