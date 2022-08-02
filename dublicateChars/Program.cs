using System.Text;

StringBuilder result = new();
StringBuilder dublicateChars = new();

string txt = "GoogleHello";

foreach (var item in txt)
{
    if (result.ToString().IndexOf(item.ToString().ToLower()) == -1)
        result.Append(item.ToString().ToLower());
    else
        if (!dublicateChars.ToString().Contains(item.ToString().ToLower()))
            dublicateChars.Append(item.ToString().ToLower()); 
}
 
Console.WriteLine(dublicateChars.ToString());
