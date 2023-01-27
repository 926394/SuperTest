Console.Clear();
string[] GetMassivNum(string[] coll)
{
    for(int index = 0; index < coll.Length; index ++)
    {
        Console.Write($"Введите {index+1} значеие из нескольких символов: ");
        coll[index] = Console.ReadLine()!;
    }
    return coll;
}

void TheFinishNum(string[] collection)
{
    for(int index = 0; index < collection.Length; index ++)
    {
        Console.Write($"{collection[index]} ");  
    }
    Console.WriteLine();
}

string[] array = new string[2];

GetMassivNum(array);
Console.WriteLine();
TheFinishNum(array);
Console.WriteLine();
