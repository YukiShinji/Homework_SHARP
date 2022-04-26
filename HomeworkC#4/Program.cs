
int[] CreatRandomArray(int size, int minVal, int maxVal) {
    int[] array = new int[size];
    Console.Write("Your massive: ");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
    return array;
    
}

// Task 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
void showEvenNumbers (int[] userArray) {
    int arrayCount = 0;
    for (int i = 0; i < userArray.Length; i ++) {
        if (userArray[i] % 2 == 0) {
            arrayCount ++;
        }
    }
    if (arrayCount == 0) {
        Console.WriteLine("There are no even numbers in this array ");
    }   else {
        Console.WriteLine("There are " + arrayCount + " even numbers in this array ");
    }
}

Console.WriteLine("Insert size, min and max value in massive ");
Console.Write("Insert size ");
int userSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert min value ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert max value ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());

int[] userRandomMassive = CreatRandomArray(userSize, userMinValue, userMaxValue);
showEvenNumbers(userRandomMassive);
*/

// Task 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int sumOfOddNumbersInTheArray (int[] userArray) {
    int sumOfOddNumbers = 0;
    for (int i = 0; i < userArray.Length; i++) {
        if (userArray[i] % 2 != 0) {
            sumOfOddNumbers += userArray[i];
        }
    }
    return sumOfOddNumbers;
}

Console.WriteLine("Insert size, min and max value in massive ");
Console.Write("Insert size ");
int userSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert min value ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert max value ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());

int[] userRandomMassive = CreatRandomArray(userSize, userMinValue, userMaxValue);
int summOddNumbers = sumOfOddNumbersInTheArray(userRandomMassive);
Console.WriteLine("This is a summ odd numbers: " + summOddNumbers);
*/

// Task 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
void differenceBetweenTheMaximumAndMinimumArrayElements (int[] userArray, int userMinValue, int userMaxValue) {
    int between = 0;
    int maxVal = userMinValue;
    int minVal = userMaxValue;

    for (int i = 0; i < userArray.Length; i ++) {
        if (userArray[i] > maxVal) {
            maxVal = userArray[i];
        }   else if (userArray[i] < minVal) {
            minVal = userArray[i];
        }
    }
    Console.Write("This is your's between: " + (between = maxVal-minVal));

}
Console.WriteLine("Insert size, min and max value in massive ");
Console.Write("Insert size ");
int userSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert min value ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert max value ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());

int[] userRandomMassive = CreatRandomArray(userSize, userMinValue, userMaxValue);
differenceBetweenTheMaximumAndMinimumArrayElements(userRandomMassive, userMinValue, userMaxValue);
*/