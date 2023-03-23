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


