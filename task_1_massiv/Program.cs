// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int vvod(string text)
{
    Console.WriteLine(text);

        int V = int.Parse (Console.ReadLine());
        return V;
}
try
{
int m = vvod("введите количество строк в массиве (>0):  ");
int n = vvod("введите количество столбцов в массиве(>0):  ");
if (m>0 & n>0)
{
double[,]massiv = new double[m,n];
Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        massiv [i,j] = Convert.ToDouble (rnd.Next(-1000,1000)/10.0);
        Console.Write($"{massiv[i,j]}   ");
    }
    Console.WriteLine();
}
}
else
{
    Console.WriteLine("Вы ввели не число или число <=0");
}
}
catch
{
    Console.WriteLine("Вы ввели не число или число <=0");
}