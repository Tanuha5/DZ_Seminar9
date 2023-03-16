// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetResult(m, n, 0));
int GetResult(int numM, int numN, int sum)
{
    sum = sum + numN;
    numN--;
    if (numN < numM)
    {
        return sum;
    }
    return GetResult(numM, numN, sum);
}

