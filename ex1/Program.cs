/* Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
int Getnumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.WriteLine("Введено не число или не корректное число");
        }
    }
    return result;
}

void Raisetopower(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result *= a;
    }
    Console.WriteLine($"Число {a} в степени {b} равно {result}");
}
int a = Getnumber("Введите основание степени:");
int b = Getnumber("Введите показатель степени:");
Raisetopower(a, b);
