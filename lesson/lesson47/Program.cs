Console.Write("Введите количество строк ");
int rows=int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns=int.Parse(Console.ReadLine());
double[,]array=GetArray(rows,columns,-10,10);

double[,]GetArray(int m,int n, int minValue,int maxValue){
   double[,]result=new double [m,n];
    
    for(int i = 0; i<m;++i){
       for(int j = 0; j<n;++j){
        result[i,j]=new Random().Next(minValue,maxValue+1) + new Random().NextDouble();
       } 
    }
    return result;
}
void PrintArray (double[,]array)
{
   for(int i=0; i<array.GetLength(0); i++ ){
    for(int j = 0; j<array.GetLength(1);j++ ){
        Console.Write(array[i,j]+ " ");
    }
    Console.WriteLine();
   }
}
double[,]result = GetArray(rows,columns,-10,10);
PrintArray(array);

