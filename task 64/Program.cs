//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все чётные числа в промежутке от N до 1.
int n = InputInt("Введите число ");
int m = 0;
if (n < 1)
{
    Console.WriteLine("Введите число более 1 !");
}
int NaturalNumber(int n, int m)
{
    if (n > m)
        Console.Write($"{NaturalNumber(n, m+2)}, ");
    else
        return n;

    return m;
}
Console.WriteLine(NaturalNumber(n, m+2));

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}