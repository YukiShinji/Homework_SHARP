// Task 1: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int findSummBeetwenNumber(int usernum1, int usernum2){
    int result = usernum1;
    for (int i = ++usernum1; i <= usernum2; i++){
        result += i;
        findSummBeetwenNumber(++usernum1, usernum2);
    }
    return result;
}

Console.Write("Insert number first: ");
int userFirstNumber = Convert.ToInt16(Console.ReadLine());
Console.Write("Insert number second: ");
int userSecondNumber = Convert.ToInt16(Console.ReadLine());

int finalSumm = findSummBeetwenNumber(userFirstNumber, userSecondNumber);
Console.WriteLine("Summ is: " + finalSumm);
*/

// Task 2: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int summInUserNumber(int userNumber1) {
    if (userNumber1 / 10 != 0) {
        return userNumber1 % 10 + summInUserNumber(userNumber1 / 10); 
    }   else {
            return userNumber1 % 10;
        }
}

Console.Write("Insert your number: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
int finalNumber = summInUserNumber(userNumber1);
Console.WriteLine("Summ numbers in number: " + finalNumber);
*/