using static MyMethod.MyMethod;
using MyMethod;
using home_task2;
MyGenerate gen = new MyGenerate();

/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m = IntInput("число M");
int n = IntInput("число N");

try{
int[] natureArray = NatureNumbers(m,n);
int result = SumOfElements(natureArray);
Print(natureArray);
Print($"Сумма элементов равна {result}");

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

int SumOfElements (int[] array, int startSum = 0, int i = 0){
    if (i<0) return startSum;
    for (i=i; i< array.Length; i++){
        return SumOfElements(array, startSum+array[i], i+1);
    }
    return startSum;
}