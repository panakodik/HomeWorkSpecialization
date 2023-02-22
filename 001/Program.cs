// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам
Console.WriteLine("Имеющийся массив строк");
string[] originalStrings = { "driver", "Home", "window", "you", "my", "car" };
string[] shortStrings = new string[originalStrings.Length];
int count = 0;