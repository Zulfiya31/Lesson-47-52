// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер строки ");
int rows = int.Parse(Console.ReadLine())-1 ;
Console.Write("Введите номер столбца ");
int columns = int.Parse(Console.ReadLine())-1 ;
int n = 3; 
int m = 4;
Random ArrayLength = new Random();
int[,] array = new int[n, m];
Console.WriteLine("Массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = ArrayLength.Next(-10, 10);
        Console.Write(array[i, j]+" ");
    }
    Console.WriteLine();
}
if (rows < 0 || rows > array.GetLength(0) - 1 || columns < 0 || columns > array.GetLength(1) - 1)
{
    Console.WriteLine("Элемента нет ");
}
else
{
    Console.WriteLine(" Элемент массива =   "+ array[rows, columns]);
}
Console.ReadLine();



