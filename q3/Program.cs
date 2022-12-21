using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12 45 -> 9
*/

int SumOfDigits (int n)
{
    if (n / 10 == 0) 
    {
        return n; 
    }
    else
    {
        return SumOfDigits(n/10) + n%10; 
    }
}