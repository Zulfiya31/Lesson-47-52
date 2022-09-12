// двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Write("Введите строку ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите столбец ");
int columns=int.Parse(Console.ReadLine());

int[,]GetArray(int m,int n,int minValue, int maxValue){
int[,]result=new int[m, n];
    
    for(int i = 0; i<m;++i){
       for(int j = 0; j<n;++j){
        result[i,j]=new Random().Next(minValue, maxValue+1);;
       } 
    }
    return result;
}
   void PrintArray (int[,]array){
      for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
   }
   }
int[,]array = GetArray(rows,columns, 0,10);
PrintArray(array);
Console.WriteLine("Число столбцов - " + array.GetLength(1));
Console.WriteLine ("Среднеарифметическое элементов => " );
for (int j = 0; j < array.GetLength(1); j++)
{
double sum = 0;
double SrAr = 0;
for (int i = 0; i < array.GetLength(0); i++){
    sum+= array[i,j];
}
SrAr = Math.Round(sum/array.GetLength(0),2);
Console.Write(SrAr + " ");
}
