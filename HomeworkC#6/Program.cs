// Task 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void biggerThenZero (int[] userMassive) {
    int count = 0;
    for (int i = 0; i < userMassive.Length; i++)
    {
        if (userMassive[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine("Elements > 0: " + count);
}

Console.Write("Insert numbers this whitespace: ");
int[] userMassive = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
biggerThenZero(userMassive);
*/

// Task 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
/*
void conversionToBinaryNotation (int userNumber) {

    string count = "";
    while (userNumber > 0)
        {
            count = ((userNumber % 2 == 0) ? "0" : "1") + count;
            userNumber /= 2;
        }
    Console.WriteLine(count);
}

Console.Write("Insert number: ");
int userNumberForWork = Convert.ToInt32(Console.ReadLine());
conversionToBinaryNotation(userNumberForWork);
*/

// Task 3: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void thePointOfIntersection (double k1, double b1, double k2, double b2) {

    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    Console.WriteLine("Пересечение в точке: " + x + ";" + y);

}

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

thePointOfIntersection(k1, b1, k2, b2);
*/