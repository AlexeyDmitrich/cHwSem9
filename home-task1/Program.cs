using static MyMethod.MyMethod;
using MyMethod;
using home_task1;
MyGenerate gen = new MyGenerate();

/*
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int m = IntInput("число M");
int n = IntInput("число N");

try{
int[] result = NatureNumbers(m,n);
} catch (Exception e){
    Console.ForegroundColor = ConsoleColor.Red;
    Print($"Произошла ошибка : {e.Message}");
    Console.ResetColor();
}
int[] NatureNumbers(int m, int n)
{

    if (m > n) {
        throw new Exception("Некорректное расположение чисел");
    }

    int length;   // вызвано вероятностью введения отрицательных чисел
    if (m < 0)
    {
        length = Md(m);
    }
    else length = m;

    int[] resArray = new int[length];
    IntArray workingArray = new IntArray(0);  // здесь я переопределяю сам объект массива 
                                              // для добавления в него новых элементов

    NatureNumbers(n, workingArray, m);
    Print("");

    int[] res = workingArray.Pack();
    
    void NatureNumbers(int n, IntArray workingArray, int m = 1)
    {
        if (m > n)
        {
            return;
        }
        //Console.Write($"{n} ");
        workingArray.Add(n);
        NatureNumbers(n - 1, workingArray, m);
    }
    return res;
}