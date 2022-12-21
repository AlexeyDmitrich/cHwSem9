using static MyMethod.MyMethod;
using MyMethod;

MyGenerate gen = new MyGenerate();

/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int n = IntInput("число N");


NatureNumbers(1, n);
Print("");

void NatureNumbers (int start=1, int n){
    
    if (n < start) {
        return;
    } 
    Console.Write($"{start} ");
    NatureNumbers(start+1, n);

}
