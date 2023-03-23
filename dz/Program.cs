Console.WriteLine("Введите текст :  ");
string text = Console.ReadLine();

/// <summary>
/// Метод удаляет знаки препинания и преобразует текст в массив
/// </summary>
/// <param name="str">Текст </param>
/// <returns>МСтроковый массив</returns>
string[] DelPunctuatMark(string str)
{
    string[] delMark = { ".", ",", "(", ")" };
    for (int i = 0; i < delMark.Length; i++)
    {
        str = str.Replace(delMark[i], string.Empty);
    }
    return str.Split(" ");
}

/// <summary>
/// Метод запоминае слова длиной не превышающей заданой длины
/// </summary>
/// <param name="str"></param>
/// <returns></returns>
string[] ArreyWords(string[] str,int maxLength)
{
    string newStr = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= maxLength)
        {
            newStr = newStr + str[i] + " ;";
        }
    }
    newStr = newStr.Trim();
    return newStr.Split(" ");
}

Console.WriteLine($"Текст который вы ввели: \n");
Console.WriteLine($"{text} \n");
Console.WriteLine("Слова не превышающие длину 3 символа в данном тексте");
string[] array = ArreyWords(DelPunctuatMark(text),3);
Console.Write($"\n {string.Join(' ', array)}");