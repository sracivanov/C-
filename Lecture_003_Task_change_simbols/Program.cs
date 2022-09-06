// "Рядом с домом росли высокие деревья и располагалась лавочка"

// string s = "qwerty"
//             012345  
// s / 5            y 

string text = "hello world";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
        return result;
}

string newText = Replace(text, 'h', 'H');
Console.WriteLine(newText);

newText = Replace(newText, 'w', 'W');
Console.WriteLine(newText);

newText = Replace(newText, ' ', '|');
Console.WriteLine(newText);


