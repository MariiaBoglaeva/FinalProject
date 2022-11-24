// Написать программу, которая из имеющегося массива строк,
// формирует массив из строк, длина которых меньше либо равно 3 символа.
// Первоначальный массив можно задать на старте либо ввести с клавиатуры.

Console.WriteLine("Введите исходный массив: ");
string[] words = Console.ReadLine().Split(new char[] { ',',' ',';','.'});
string[] shortWords = CreateShortWordsArray(words, 3);
PrintArray(shortWords);

string[] CreateShortWordsArray(string[] allWords, int amountChar)
{
    string[] shortWords = new string[allWords.Length];
    int index = 0;
    for (int i = 0; i < allWords.Length; i++)
    {
        if (allWords[i].Length <= amountChar)
        {
            shortWords[index] = allWords[i];
            index++;
        }
    }
    Array.Resize(ref shortWords, index);
    return shortWords;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}