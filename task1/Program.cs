/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B(решено циклом)");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    Console.WriteLine("Введите число");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа");
    int userPower = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int count = 0; count < userPower; count++)
    {
        result = result * userNumber; 
    }
    Console.WriteLine($"Ваше число {userNumber} в степени {userPower} -> {result}");

Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
    Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
    userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");