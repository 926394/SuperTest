Console.Clear();
Console.Write("Здравствуйте!");
Console.WriteLine();
string[] OneMassivStr(string[] strMass1)
{
    for (int i = 0; i < strMass1.Length; i++)
    {
        Console.Write($"Введите {i + 1} значеие из нескольких символов: ");
        strMass1[i] = Console.ReadLine()!;
    }
    return strMass1;
}


string[] SortingMetod(string[] firstMass)
{
    string[] strMass2 = new string[firstMass.Length];
    for (int i = 0,f = 0; i < firstMass.Length; i++)
    {
        if (firstMass[i].Length <= 3)
        {
            strMass2[f] = firstMass[i];
            f++;
        }
    }
    return strMass2;
}

string[] TheAnswString(string[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"{collection[i]} ");
    }
    return collection;
}

string[] array = new string[5];

OneMassivStr(array);
Console.WriteLine();
TheAnswString(array);
Console.WriteLine();
string[] endStr = SortingMetod(array);
Console.WriteLine();
TheAnswString(endStr);
Console.WriteLine();
Console.WriteLine();