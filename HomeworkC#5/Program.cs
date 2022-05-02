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