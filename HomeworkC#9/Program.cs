// Task 1: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void findSummBeetwenNumber(int userFirstNumber, int userSecondNumber) {
    int countNumbers = 0;
    for (int i = userFirstNumber; i <= userSecondNumber; i++)
        countNumbers += i;
    Console.WriteLine(countNumbers);
}

Console.Write("Insert number first: ");
int userFirstNumber = Convert.ToInt16(Console.ReadLine());
Console.Write("Insert number second: ");
int userSecondNumber = Convert.ToInt16(Console.ReadLine());

findSummBeetwenNumber(userFirstNumber, userSecondNumber);
*/

// Task 2: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
void summInUserNumber (int userNumber) {
    int summ = 0;
    int delen = 0;

    while(userNumber > 0) {
        delen = userNumber % 10;
        summ = summ + delen;
        userNumber = userNumber / 10;
    }
    Console.WriteLine("Summ number is: " + summ);
}

Console.WriteLine("Insert your number: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
summInUserNumber(userNumber1);
*/