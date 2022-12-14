// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetArray (int m, int n)
{
int [,] matrix = new int[m,n];
for (int i = 0; i < matrix.GetLength(0); i++) 
    {

    for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = new Random().Next(11);
        }
    }
return matrix;
}

int [,] result = GetArray(rows,columns); 

 void PrintArray (int [,] inputMatrix)
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

Console.Write("Введите строку нужного элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец нужного элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row <= rows && column <= columns)
    Console.Write("Ваш элемент: " + result[row, column]);
else
    {
    Console.Write("Такого элемента не существует");
    }
