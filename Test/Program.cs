Console.Clear();

Console.Write("Здравствуйте!");
Console.WriteLine();
string[] OneMassivStr(string[] coll)
{
    for (int index = 0; index < coll.Length; index++)
    {
        Console.Write($"Введите {index + 1} значеие из нескольких символов: ");
        coll[index] = Console.ReadLine()!;
    }
    return coll;
}

string[] SortingMetod(string[] line)
{
    string[] res = new string[line.Length];

    for (int i = 0; i < line.Length; i++)
    {
        string lin = line[i];
        int f = lin.Length;
        if (f <= 3)
        {
            res[i] = line[i];
        }
    }
    return res;
}

void TheAnswString(string[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        Console.Write($"{collection[index]} ");
    }
    // return collection;
}

string[] array = new string[5];

OneMassivStr(array);
Console.WriteLine();
TheAnswString(array);
Console.WriteLine();
string[] endStr = SortingMetod(array);
Console.WriteLine();
TheAnswString(endStr);
