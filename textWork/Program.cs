// Дан текст. В тексте на русском языке, нужно все пробелы заменить на "-"
// и маленькие буквы "а" заменить на большие"А"

string text = "Да, вы правы. В моем предыдущем ответе была допущена ошибка."
+ " 'Граб' не является деревом. Я приношу извинения за путаницу."
+ " Корректные переводы названий деревьев, упомянутых в загадке,";

string Replace(string txt, char oldValue, char newValue) {
    string result = string.Empty;

    for (int i = 0; i < txt.Length; i++)
    {
        if(txt[i] == oldValue) result += $"{newValue}";
        else result += $"{txt[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '-');
Console.WriteLine(text);
Console.WriteLine();
Console.WriteLine(newText);
Console.WriteLine();
Console.WriteLine(Replace(newText, 'а', 'А'));