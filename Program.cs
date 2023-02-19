// Задача 41.
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
Console.WriteLine("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

Console.WriteLine("Введите числa: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите a[{i}]: ");
    array[i] = Convert.ToInt32(Console.ReadLine()); 
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count += 1;
    else
        count += 0;    
}

Console.WriteLine($"Количество чисел, больших 0: {count}");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Input k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 2);
y = Math.Round(y, 2);
 
Console.WriteLine($"The intersection point: ({x};{y})");




 

