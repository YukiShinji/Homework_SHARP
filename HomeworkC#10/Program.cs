// Task 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/*
static int fountSummSring(String InputString)  {
        int Count = 0;

        String[] StringMass = InputString.Split(' ');
        foreach (var Slovo in StringMass)
            if (Slovo.StartsWith('a') || Slovo.StartsWith('e') || Slovo.StartsWith('y') || Slovo.StartsWith('u') || Slovo.StartsWith('i') || Slovo.StartsWith('o'))
                Count++;
        return Count;
}
 
 
Console.Write("Insert the string: ");
String str = Console.ReadLine().ToLower();

Console.Write(fountSummSring(str));
*/

// Task 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
/*
string[] factMassive =  {"qwe", "wer", "ert", "rty", "tyu", "yui"};

string[] doingTheNewMassive (string[] factMassive) {
   
    string[] newMassive = {};

    for (int i = 0; i < factMassive.Length; i = i + 2) {
        newMassive[i] = factMassive[i] + factMassive[i+1];
    }
    return newMassive;
}



Console.WriteLine(doingTheNewMassive(factMassive));
Console.WriteLine("The main massive: " + factMassive);
*/

// Я так и не понял где ошибка во второй задаче