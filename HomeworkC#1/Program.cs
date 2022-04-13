// Task 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) {
    Console.Write(num1 + " Bigger then " + num2);
}   else {
    Console.Write(num2 + " Bigger then " + num1);
}
*/

// Task 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 & num1 > num3) {
    Console.Write(num1 + " Bigger then " + num2 + " and " + num3);
}   else if (num2 > num1 & num2 > num3) {
    Console.Write(num2 + " Bigger then " + num1 + " and " + num2);
}   else if (num3 > num2 & num3 > num1) {
    Console.Write(num3 + " Bigger then " + num2 + " and " + num1);
}
*/

// Task 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
    Console.WriteLine("Number " + num + " is even ");
}   else if (num % 2 != 0) {
    Console.WriteLine("Number " + num + " is odd ");
}   else {
    Console.WriteLine("Wrong input ");
}
*/

// Task 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input number ");
int num = Convert.ToInt32(Console.ReadLine());

while (num >= 1) {
    if (num % 2 == 0) {
        Console.Write(num + " ");
    }   else {
        Console.WriteLine("Wrong number ");
    }
    num --;
}
*/