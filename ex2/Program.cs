/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Getnumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result>=0)
        {
            break;
        }
        else
        {
        Console.WriteLine("Введено не число или не корректное число");
        }
    }
    return result;
}
void Sumdigit(int number) 
{ 
int sum=0;
    for(int num = number; num>0; num/=10)
    {
        sum+=num%10;
    }
        Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
}
int number=Getnumber("Введите натуральное число:");
Sumdigit(number);