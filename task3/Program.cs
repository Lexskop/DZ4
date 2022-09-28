/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/
int randomNum(int min, int max)
{
    int num = new Random().Next(min, max);
    return num;
}

void PrintArray(int[] collection)
{
    Console.Write($"Ваша длина массива {collection.Length} -> [");
    for (int index = 0; index < collection.Length-1; index++)
    {
        Console.Write($"{collection[index]},");
    }
    Console.Write($"{collection[collection.Length-1]}");
    Console.WriteLine("]");
}

Console.Clear();
Console.WriteLine("Приветствую! Эта программа принимает от пользователя длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран");
string userChoice = "y";
while (userChoice.ToLower() == "y")
{
    Console.WriteLine("Введите длину массива:");
    int userLength = Convert.ToInt32(Console.ReadLine());
   
    int[] arr = new int[userLength];
    for (int i = 0; i < userLength; i++)
    {
        arr[i] = randomNum(1, 99);
    }
    PrintArray(arr);

    Console.WriteLine("Вы хотите продолжить работу с программой? Да - Y, Нет - N");
    userChoice = Console.ReadLine();
    while (userChoice.ToLower() != "y" && userChoice.ToLower() != "n")
    {
    Console.WriteLine("Пожалуйста, введите верное решение. Если хотите продолжить работу - введите Y, если желаете закрыть программу - введите N");
    userChoice = Console.ReadLine();
    }
}
Console.WriteLine("Bye!");