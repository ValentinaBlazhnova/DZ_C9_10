/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
Функция Аккермана определяется следующим образом:
A( 0,y ) = y+1;
A( x,0 ) = A( x-1, 1 );
A( x,y ) = A( x-1, A( x, y-1 ) ).
Здесь x и y – целые неотрицательные числа.*/

int m = Input("Введите число m: ");
int n = Input("Введите число n: ");

Console.WriteLine(Ackerman(m, n));

int Ackerman(int m, int n) 
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
}

int Input(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

