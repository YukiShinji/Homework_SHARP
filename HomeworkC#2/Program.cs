// Task 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void gettingTheSecondNumber (int numFromUser) 
{
    int theSecondNumber = numFromUser / 10 % 10;

    if (numFromUser > 999 && numFromUser < 100) {
        Console.WriteLine("Number is not three hundred ");
    }   else {
        Console.WriteLine("The second number from three hundred is " + theSecondNumber);
    }
}

Console.Write("Insert your three hundred number ");
int userNumber = Convert.ToInt32(Console.ReadLine());
gettingTheSecondNumber(userNumber);
*/
// Первая задача работает только для трехзначных чисел.


// Task 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
void gettingTheThirdNumber (int numFromUser) 
{

    if (numFromUser < 100) {
        Console.WriteLine("Third number is not found ");
    }   else if (numFromUser >= 100 && numFromUser <= 999) {
        int thirdNumber = numFromUser % 10;
        Console.WriteLine("Therd number is " + thirdNumber);
    }   else if (numFromUser >= 1000 && numFromUser <= 9999) {
        int thirdNumber = numFromUser / 10 % 10;
        Console.WriteLine("Therd number is " + thirdNumber);
    }   else if (numFromUser >= 10000 && numFromUser <= 99999) {
        int thirdNumber = numFromUser / 100 % 10;
        Console.WriteLine("Therd number is " + thirdNumber);
    }   else if (numFromUser >= 100000 && numFromUser <= 999999) {
        int thirdNumber = numFromUser / 1000 % 10;
        Console.WriteLine("Therd number is " + thirdNumber);
    }
}

Console.Write("Insert your number ");
int userNumber = Convert.ToInt32(Console.ReadLine());
gettingTheThirdNumber(userNumber);
*/
// Придумал такое костыльное решение. Был еще вариант с помощью массива, но этот вариант мне показался быстрее и легче для воприятия, несмотря на свою не особую вариативность.

// Task 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void gettingADayOF (int numFromUser) 
{
    if (numFromUser == 1) {
        Console.WriteLine("Monday is a working day ");
    }   else if (numFromUser == 2) {
        Console.WriteLine("Tuesday is a working day ");
    }   else if (numFromUser == 3) {
        Console.WriteLine("Wednesday is a working day ");
    }   else if (numFromUser == 4) {
        Console.WriteLine("Thursday is a working day ");
    }   else if (numFromUser == 5) {
        Console.WriteLine("Friday is a working day ");
    }   else if (numFromUser == 6) {
        Console.WriteLine("Saturday is a day off ");
    }   else if (numFromUser == 7) {
        Console.WriteLine("Sunday is a day off ");
    }   else {
        Console.WriteLine("Incorrect a number of a week day ");
    }
}

Console.Write("Insert number of a weekday ");
int userNumberOfDay = Convert.ToInt32(Console.ReadLine());
gettingADayOF(userNumberOfDay);
*/