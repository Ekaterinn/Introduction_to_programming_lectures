// Дан текст. В тексте нужно все пробелы заменить черточками.
// Маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красновечивы. Вы дадите мне чаю?";
// string s = "beautiful"
//             012345678
// s[3] = u
string Car(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result+$"{newValue}";
        else result = result+$"{text[i]}";
    }
    return result;
}
string newText = Car(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Car(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Car(newText, 'с', 'С');
Console.WriteLine(newText);