// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам
Console.WriteLine("Имеющийся массив строк");
string[] originalStrings = { "driver", "Home", "window", "you", "my", "car" };
string[] shortStrings = new string[originalStrings.Length];
int count = 0;

// проходим по каждой строке в исходном массиве
foreach (string s in originalStrings)
{
    Console.Write("*" + s + "* ");
    // если длина строки <= 3, добавляем ее в новый массив
    if (s.Length <= 3)
    {
        shortStrings[count] = s;
        count++;
    }
}

Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых <= 3 символам");
// выводим новый массив
for (int i = 0; i < count; i++)
{
    Console.Write("*" + originalStrings[i] + "* ");
}