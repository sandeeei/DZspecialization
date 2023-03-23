Console.WriteLine("Введите текст :  ");
string text = Console.ReadLine();

string[] DelPunctuatMark(string str)
{
    string[] delMark = { ".", ",", "(", ")" };
    for (int i = 0; i < delMark.Length; i++)
    {
        str = str.Replace(delMark[i], string.Empty);
    }
    return str.Split(" ");
}


string[] ArreyWords(string[] str)
{
    int maxLength = 3;
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

