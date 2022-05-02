// Task 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
void returnOfNatural (int userNameA, int userNameB) {
    int newReturnNumber = 1;
    for (int i = 0; i < userNameB; i++) {
        newReturnNumber = newReturnNumber * userNameA;
    }
    Console.WriteLine("Your number is: " + newReturnNumber);
}

Console.WriteLine("Insert two number: ");
Console.Write("Insert first number: ");
int usernumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert second number: ");
int usernumberB = Convert.ToInt32(Console.ReadLine());

returnOfNatural(usernumberA, usernumberB);
*/

// Task 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int sumOfDigits(int numberUser)
{
   int sum = 0;
   while (numberUser > 0) {
      int rem;
      numberUser = Math.DivRem(numberUser, 10, out rem);
      sum += rem;
   }
   return sum;
}

Console.Write("Insert number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int finalNumber = sumOfDigits(userNumber);
Console.WriteLine("This is the summ: " + finalNumber);
*/

// Task 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
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

Console.WriteLine("Insert size, min and max value in massive ");
Console.Write("Insert size ");
int userSize = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert min value ");
int userMinValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert max value ");
int userMaxValue = Convert.ToInt32(Console.ReadLine());

CreatRandomArray(userSize, userMinValue, userMaxValue);
*/