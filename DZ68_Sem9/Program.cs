// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
AccermanFunction(m,n);

void AccermanFunction(int m, int n)
{
    Console.Write(Accerman(m, n)); 
}

int Accerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numM > 0 && numN == 0)
    {
        return Accerman(numM - 1, 1);
    }
    else
    {
        return Accerman(numM - 1, Accerman(numM, numN - 1));
    }
}


