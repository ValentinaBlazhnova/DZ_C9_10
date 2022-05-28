/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int firstNumber = Input("Введите первое число: ");
int secondNumber = Input("Введите второе число: ");
int count = 1;

Console.WriteLine(SumNumbers(firstNumber,secondNumber));

int SumNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return firstNumber;
    return firstNumber + SumNumbers(firstNumber + count, secondNumber);
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
