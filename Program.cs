// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// void PrintMToN(int m, int n)
// {
//     if (n < m)
//     {
//         return;
//     }

//     PrintMToN(m, n - 1);

//     Console.Write(n + " ");

// }
// PrintMToN(2, 5);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// int AckermannFunction(int m, int n)
// {

//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return AckermannFunction(m - 1, 1);
//     }
//     else if (m > 0 && n > 0)
//     {
//         return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//     }
//     else
//     {
//         return -1;
//     }
// }

// Console.Write(AckermannFunction(3, 0));
// // в презентации возможно опечатка: m = 2, n = 3->A(m, n) = 29 (выводит 9)
// // при m = 3  n=0 вывод равен 5, а не 4

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.
void PrintArrey(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        
        PrintArrey(array, i + 1);
        Console.Write($"{array[i]} ");
    }

}
int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrey(array);