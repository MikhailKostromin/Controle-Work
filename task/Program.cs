// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.


string[] text = FillArray();


string[] FillArray()   // Заполняем массив
{
    Console.WriteLine("Введите текстовый массив/слова через пробел");
    return Console.ReadLine().Split(" ");
}
Console.WriteLine($"[{string.Join(", ", text)}]");

Console.WriteLine("Введите максимальную длину строки которую оставим в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int CountLess(string[] input, int n) // Считаем строки меньше трех символов
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}