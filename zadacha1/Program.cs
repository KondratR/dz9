// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Sum(m,n,0);

void Sum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма = {sum}"); 
        return;
    }
    sum = sum + (numM++);
    Sum(numM, numN, sum);
}