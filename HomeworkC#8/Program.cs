// Task 1: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива
/*
Console.Write("Input X of matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y of matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"x = {x}, y = {y}");

int[,] array = new int[x, y];

void CreateArrayMatrix(int[,] array) {
    for (int i = 0; i < x; i++) {
        for (int j = 0; j < y; j++) {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void WriteArrayMatrix (int[,] array) {
    

    for (int i = 0; i < x; i++) {
        for (int j = 0; j < y; j++) {
            int alignNumber = array[i, j];
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}

CreateArrayMatrix(array);
Console.WriteLine("This is double massive");
WriteArrayMatrix(array);

void sortRowWise(int [,]massive) {
    Console.WriteLine("This is sorted massive: ");
        for (int i = 0; i < massive.GetLength(0); i++) {
            for (int j = 0; j < massive.GetLength(1); j++) {
                for (int k = 0; k < massive.GetLength(1) - j - 1; k++) {
                
                if (massive[i, k] > massive[i, k + 1]) {

                    int t = massive[i, k];
                    massive[i, k] = massive[i, k + 1];
                    massive[i, k + 1] = t;
                }
            }
        }
    }
}

sortRowWise(array);
WriteArrayMatrix(array);
*/

// Task 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.Write("Input X of matrix: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y of matrix: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"x = {x}, y = {y}");

int[,] array = new int[x, y];

void CreateArrayMatrix(int[,] array) {
    for (int i = 0; i < x; i++) {
        for (int j = 0; j < y; j++) {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void WriteArrayMatrix (int[,] array) {
    

    for (int i = 0; i < x; i++) {
        for (int j = 0; j < y; j++) {
            int alignNumber = array[i, j];
            Console.Write(alignNumber + " ");
        }
        Console.WriteLine();
    }
}

CreateArrayMatrix(array);
Console.WriteLine("This is double massive");
WriteArrayMatrix(array);

void findSummInMassive (int[,] array) {
    int minRowSum = int.MaxValue, indexMinRow = 0;
 
            for (int i = 0; i < x; i++) {
                int rowSum = 0;
                for (int j = 0; j < y; j++)
                    rowSum += array[i, j];
                
                if (rowSum < minRowSum) {
                    minRowSum = rowSum;
                    indexMinRow = i;
                }
            }
            indexMinRow = indexMinRow + 1;
            Console.WriteLine("String this minimal value is: " + indexMinRow);
                
}

findSummInMassive(array);

*/

// Task 3: Заполните спирально массив 4 на 4
/*
int[] inputTheLine (int[] massive, int[,] matrix) {
    massive[6]++;
    matrix[massive[3], massive[4]] = massive[5];
    massive[5]++;
    massive[3] += massive[1];
    massive[4] += massive[2];
    if (massive[6] < ((massive[0]-1) - massive[8])) {
        return inputTheLine (massive, matrix);
    }
    massive[7]++;
    return massive;
}

int intoSpiral (int[,] matrix, int[] massive, int N) {
    
    if (massive[5] == massive[9] + 1) return 0;
    if ((massive[7] + 4) % 4 == 0) {massive[1] = 0; massive[2] = 1;}
    if ((massive[7] + 4) % 4 == 1) {massive[1] = 1; massive[2] = 0;}
    if ((massive[7] + 4) % 4 == 2) {massive[1] = 0; massive[2] = -1;}
    if ((massive[7] + 4) % 4 == 3) {massive[1] = -1; massive[2] = 0;}
    massive = inputTheLine(massive, matrix);
    if ((massive[7] + 4) % 4 == 0) {
        massive[8] += 2;
        massive[1] = 0; 
        massive[2] = 0;
        massive[3] = massive[8] / 2; massive[4] = massive[8] / 2;
    }
    massive[6] = 0;
    return intoSpiral(matrix, massive, N);
}

int Z = 7;
int[] massive = new int[11];
int[,] newArray = new int[Z, Z];
massive[0] = Z;
massive[1] = 0; massive[2] = 0; massive[3] = 0; massive[4] = 0; massive[5] = 1; massive[6] = 0; massive[7] = 0; massive[8] = 0;
massive[9] = Convert.ToInt32(Math.Pow(Z, 2));

void WriteArrayMatrix (int[,] array){
for (int i = 0; i < Z; i++)
  {
      for (int j = 0; j < Z; j++)
      {
        int alignNumber = array[i, j];
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}

intoSpiral(newArray, massive, massive[0]);
WriteArrayMatrix(newArray);
*/