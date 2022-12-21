using static MyMethod.MyMethod;
using MyMethod;
using System;
using System.Diagnostics;
MyGenerate gen = new MyGenerate();

/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8
*/


Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int b = int.Parse(Console.ReadLine());
Stopwatch watch = new Stopwatch();
watch.Start();
double num = 0;
for (int i = 0; i < 1000000; i++)
{
   num = NumberAtoNumberB(a, b); 
}
watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);
Console.WriteLine(num);
double NumberAtoNumberB (int c, int d)
{
    if (d == 0) return 1;
    else
    {
        if (d%2 == 0) return NumberAtoNumberB(c, d/2) * NumberAtoNumberB(c, d/2);
        else return c * NumberAtoNumberB(c, d - 1);
    }
}
double GetExponential(int a, int b) {
    double result = 1;
    if(b == 0) {
        return 1;
    }

    for(int i = 0; i < Math.Abs(b); i++) {
        result = result * a;
    }

    if(b < 0) {
        return 1 / result;
    }

    return result;
}

