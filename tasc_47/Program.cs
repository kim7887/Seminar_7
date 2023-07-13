// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите количество строк");
int zz=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int rz=Convert.ToInt32(Console.ReadLine());
double[,] a=new double[rz,zz];

for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        a[i,j]=Random.Shared.Next(-100, 100)/10.0;
        
    }
}
for(int i=0;i<rz;i++){
    for(int j=0;j<zz;j++){
        Console.Write("{0,5}", a[i, j]);
        
    }
    Console.WriteLine();
}