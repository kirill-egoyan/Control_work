List<string> FilterArray(string[] array)
{
    List<string> newArray = new List<string>();
    foreach (string str in array)
    {
        if (str.Length <= 3)
        {
            newArray.Add(str);
        }
    }
    return newArray;
}

string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

Console.WriteLine(string.Join(", ", FilterArray(array1))); 
Console.WriteLine(string.Join(", ", FilterArray(array2))); 
Console.WriteLine(string.Join(", ", FilterArray(array3)));  

