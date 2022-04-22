// Task 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом/

/*
void searchForPalindromes (int number) {
    int numberWorking = number;
    int newNumber = 0;
    for (int count = 0; count < 5; count ++) {
        newNumber = newNumber * 10 + (numberWorking % 10);
        numberWorking /= 10;
    }

    if (number == newNumber) {
        Console.WriteLine("This number is palindrom");
    }   else {
        Console.WriteLine("This number is not palindrom");
    }
}

Console.Write("Insert your number ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 99999 || userNumber < 10000) {
    Console.WriteLine("This number is not five-digit ");
}   else {
    searchForPalindromes(userNumber);
}
*/

// Task 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
void distanceBetweenPoints (float x1, float x2, float y1, float y2, float z1, float z2) {
// Using an explicit cast

    float distance = (float)Math.Sqrt((((x1-x2) * (x1-x2)) + ((y1-y2) * (y1-y2)) + ((z1-z2) * (z1 - z2))));
    Console.WriteLine("Distance = " + distance);
}

//  Coordinates first dot
Console.WriteLine("Insert coordinates first dot ");
Console.Write("x1 = ");
float x1 = Convert.ToSingle(Console.ReadLine());
Console.Write("y1 = ");
float y1 = Convert.ToSingle(Console.ReadLine());
Console.Write("z1 = ");
float z1 = Convert.ToSingle(Console.ReadLine());

// Coordinates second dot
Console.WriteLine("Insert coordinates second dot ");
Console.Write("x2 = ");
float x2 = Convert.ToSingle(Console.ReadLine());
Console.Write("y2 = ");
float y2 = Convert.ToSingle(Console.ReadLine());
Console.Write("z2 = ");
float z2 = Convert.ToSingle(Console.ReadLine());

distanceBetweenPoints(x1, x2, y1, y2, z1, z2);
*/

// Tasl 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void outputOfTheCubeTable (int numberCube) {
    
    for (int i = 1; i <= numberCube; i ++) {
        Console.WriteLine("Number is: " + i + " and Cube  is: " + (i * i * i));
    }
}
Console.Write("Insert number ");
int userNumberCube = Convert.ToInt32(Console.ReadLine());
outputOfTheCubeTable(userNumberCube);
*/