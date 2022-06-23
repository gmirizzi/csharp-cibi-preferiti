string[] cibiPrefe = { "Pizza", "Patata", "Panzerotto", "Carne", "Pesce", "Parmigiana" };
Console.Write("Qual è il tuo cibo preferito? ");
string ciboPrefeUser = Console.ReadLine().ToLower();
while (!Array.Exists(cibiPrefe, element => element.ToLower() == ciboPrefeUser))
{
    Console.WriteLine($"Il cibo non è nella classifica dei cibi preferiti");
    Console.Write("Inseriscine un altro. ");
    ciboPrefeUser = Console.ReadLine().ToLower();
}
Console.WriteLine($"Il tuo cibo preferito è {ciboPrefeUser}");
var rand = new Random();
int indexCiboPrefe = rand.Next(cibiPrefe.Length + 1);
Console.WriteLine("Indice random: " + indexCiboPrefe);
string mioCiboPrefe = cibiPrefe[indexCiboPrefe].ToLower();
Console.WriteLine("Cibo prefe random: " + cibiPrefe[indexCiboPrefe]);

Console.WriteLine($"La lunghezza della classifica è pari a {cibiPrefe.Length}");
Console.WriteLine("Classifica dei cibi preferiti:");
for (int i = 0; i < cibiPrefe.Length; i++)
{
    if (ciboPrefeUser == mioCiboPrefe && cibiPrefe[i].ToLower() == ciboPrefeUser)
    {
        Console.WriteLine($"{i + 1}. {cibiPrefe[i]} --> abbiamo gli stessi gusti");
    }
    else if (cibiPrefe[i].ToLower() == mioCiboPrefe)
    {
        Console.WriteLine($"{i + 1}. {cibiPrefe[i]} --> questo è il mio cibo preferito");
    }
    else if (cibiPrefe[i].ToLower() == ciboPrefeUser)
    {
        Console.WriteLine($"{i + 1}. {cibiPrefe[i]} --> questo è il tuo cibo preferito");
    }
    else
    {
        Console.WriteLine($"{i + 1}. {cibiPrefe[i]}");
    }
}
Console.WriteLine("Cibo top: " + cibiPrefe[0]);
Console.WriteLine("Cibo preferito ma non troppo: " + cibiPrefe[cibiPrefe.Length - 1]);
if (cibiPrefe.Length % 2 != 0)
{
    Console.WriteLine("Cibo di mezza classifica: " + cibiPrefe[cibiPrefe.Length / 2]);
}
else
{
    Console.WriteLine("Cibi di mezza classifica: ");
    Console.WriteLine("1. " + cibiPrefe[cibiPrefe.Length / 2 - 1]);
    Console.WriteLine("2. " + cibiPrefe[cibiPrefe.Length / 2]);
}
