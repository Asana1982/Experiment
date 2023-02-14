Console.Clear();
string text =   "несет самостоятельную ответственность по своим обязательствам, может от своего имени"
            +   "приобретать и осуществлять имущественные и личные неимущественные права, исполнять"
            +   "обязанности, быть истцом и ответчиком в суде.  НКФО имеет самостоятельный баланс";
string text_char = $"{text[0]}";
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
string newText1 = Replace(newText, 'п', 'П');
string newText2 = Replace(newText1, 'с', 'С');
System.Console.WriteLine(newText2);