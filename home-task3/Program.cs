using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int m = IntInput("Значение m");
int n = IntInput("Значение n");

int res = Akkerman(m, n);
Print(res);

int Akkerman (int n, int m)
{   if (n == 0){
    return m + 1;
}
   else if (m == 0) {
    return Akkerman (n - 1, 1);
}
   else{
    return Akkerman(n - 1, Akkerman (n, m - 1));
}
}