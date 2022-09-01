// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] GetArray (int m, int n)
{
double[,] matrix = new double[m,n];
for (int i = 0; i < matrix.GetLength(0); i++) 
    {
    for (int j = 0; j < matrix.GetLength(1); j++) 
        {
        matrix[i, j] = new Random().Next(-100,110)/10.0;
        }
    }
return matrix;
}

double [,] result = GetArray(rows,columns); 
 void PrintArray (double [,] inputMatrix)
{
for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
    for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
        Console.Write(inputMatrix[i,m] + "\t"); 
        }
        Console.WriteLine();
    }
}

PrintArray(result);