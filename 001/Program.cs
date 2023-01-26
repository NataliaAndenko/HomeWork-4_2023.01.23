/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
int Prompt(string msg)
{
    Console.Write($"{msg}: ");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}
int number1 = Prompt("Введите число 1 ");
int number2 = Prompt("Введите число 2 ");
double fakt = Math.Pow(number1, number2);
Console.Write($"Ответ: {number1} в степени {number2} = {fakt}");
