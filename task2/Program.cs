/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

double calc (int number, int count, double sum)
{
    number = Math.Abs(number);
    if(number != 0)
        {
        count = (int)Math.Log10(number) + 1;
        }
    for (int index = 0; index <= count; index++)
    {
        sum = sum + (Math.Floor((number % Math.Pow(10, index + 1)) - (number % Math.Pow(10, index))) / Math.Pow(10, index));
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает на вход число и выдаёт сумму цифр в числе");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    Console.WriteLine("Введите число");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    double result = calc(userNumber, 0, 0);
    Console.WriteLine($"Сумма цифр в числе {userNumber} -> {result}");

    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
    Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
    userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");