// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,]massiv = new int[5,5];
Random rnd = new Random();
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv [i,j] = rnd.Next(0,5);
        Console.Write($"{massiv[i,j]}   ");
    }
    Console.WriteLine();
}
double srznach(int i,int j)
{
    int sum = 0;
    while (i<massiv.GetLength(0))
    {
        sum = sum+massiv[i,j];
        i++;
    }
    double sr = ((sum/Convert.ToDouble(massiv.GetLength(1))));
        return sr;
}
        for (int j = 0; j < massiv.GetLength(1); j++)
            {
                int i = 0;
                Console.WriteLine("Среднее значение в столбце "+j+" :   "+srznach(i,j));
            }   
