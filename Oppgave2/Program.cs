var range = 250;
var counts = new int[range];
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    foreach (var character in text ?? string.Empty)
    {
        char normalizedChar = char.ToLower(character);
        counts[(int)normalizedChar]++;
    }

    int totalCount = counts.Sum();

    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            double percent = (double)counts[i] / totalCount * 100;
            Console.WriteLine(character + " - " + counts[i] + " - " + percent.ToString("F2") + "%");
            /* Flytter teller og prosent til høyre side av konsollen
             string output = character + " - " + counts[i] + " - " + percent.ToString("F2") + "%";
             Console.CursorLeft = Console.BufferWidth - output.Length - 1;
             Console.WriteLine(output);
              */
        }
    }
}