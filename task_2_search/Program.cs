// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//1 7 -> такого числа в массиве нет

int[,]massiv = new int[10,10];
Random rnd = new Random();
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv [i,j] = rnd.Next(-50,50);
        Console.Write($"{massiv[i,j]}   ");
    }
    Console.WriteLine();
}
int vvod(string text)
{
    Console.WriteLine(text);

        int V = int.Parse (Console.ReadLine());
        return V;
}
try
{
int m = vvod("введите позицию строки (>0):  ");
int n = vvod("введите позицию столбца  (>0):  ");
try
{
    Console.WriteLine("На указанной позиции находится число   "+$"{massiv[m-1,n-1]}   ");
}
catch
{
    Console.WriteLine("Такой позиции в массиве нет");
}
}
catch
{
    Console.WriteLine("Вы ввели не число или число <=0");
}