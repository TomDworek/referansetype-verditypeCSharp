
Random randomNumber = new Random();
Console.WriteLine("Gjett et tall mellom 1 og 100");
double inputGuess = Convert.ToDouble(Console.ReadLine());
bool isRunning = true;
var random = randomNumber.Next(1, 101);
while (true)
{
    if (inputGuess == random)
    {
        Console.WriteLine($"Du gjettet riktig! Tallet var: {random}");
        break;
    }
    else if (inputGuess < random)
    {
        Console.WriteLine($"Tallet er høyere enn {inputGuess}");
    }
    else
    {
        Console.WriteLine($"Tallet er lavere enn {inputGuess}");
    }
    Console.WriteLine("Gjett et nytt tall mellom 1 og 100");
    inputGuess = Convert.ToDouble(Console.ReadLine());
}
