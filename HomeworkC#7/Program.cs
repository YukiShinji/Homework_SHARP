// Task 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.Write("Input X of matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y of matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"x = {x}, y = {y}");

double[,] array = new double[x, y];

void CreateArrayMatrix(double[,] array)
{
  for (int i = 0; i < x; i++)
  {
    for (int j = 0; j < y; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}
void WriteArrayMatrix (double[,] array){
for (int i = 0; i < x; i++)
  {
      for (int j = 0; j < y; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}
CreateArrayMatrix(array);
WriteArrayMatrix(array);
*/

// Task 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
Console.Write("Input X of matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y of matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"x = {x}, y = {y}");

int[,] array = new int[x, y];

void CreateArrayMatrix(int[,] array)
{
  for (int i = 0; i < x; i++)
  {
    for (int j = 0; j < y; j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}
void WriteArrayMatrix (int[,] array){
for (int i = 0; i < x; i++)
  {
      for (int j = 0; j < y; j++)
      {
        int alignNumber = array[i, j];
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}
CreateArrayMatrix(array);
WriteArrayMatrix(array);

Console.Write("Input X of your number: ");
int userNumX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y of your number: ");
int userNumY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(array[userNumY - 1,userNumX - 1]);
*/

// Task 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.Write("Input X of matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y of matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"x = {x}, y = {y}");

int[,] array = new int[x, y];

void CreateArrayMatrix(int[,] array)
{
  for (int i = 0; i < x; i++)
  {
    for (int j = 0; j < y; j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
}
void WriteArrayMatrix (int[,] array){
for (int i = 0; i < x; i++)
  {
      for (int j = 0; j < y; j++)
      {
        int alignNumber = array[i, j];
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}
CreateArrayMatrix(array);
WriteArrayMatrix(array);

for (int i = 0; i < y; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < x; j++)
  {
    arithmeticMean += array[j, i]; 
  }
  arithmeticMean = Math.Round(arithmeticMean / x, 1) ;
  Console.WriteLine($"столбца № {i+1}: {arithmeticMean}");
}
*/