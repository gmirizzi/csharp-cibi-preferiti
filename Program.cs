string[] cibiPrefe = { "Pizza", "Patata", "Panzerotto", "Carne", "Pesce", "Parmigiana" };
Console.Write("Qual è il tuo cibo preferito? ");
string ciboPrefeUser = Console.ReadLine();
Console.WriteLine($"Il tuo cibo preferito è {ciboPrefeUser}");
Console.WriteLine($"La lunghezza della classifica è pari a {cibiPrefe.Length}");
Console.WriteLine("Classifica dei cibi preferiti:");
for (int i = 0; i < cibiPrefe.Length; i++)
{
    Console.WriteLine($"{i+1}. {cibiPrefe[i]}");
}
Console.WriteLine("Cibo top: " + cibiPrefe[0]);
Console.WriteLine("Cibo preferito ma non troppo: " + cibiPrefe[cibiPrefe.Length - 1]);
if (cibiPrefe.Length % 2 != 0)
{
    Console.WriteLine("Cibo di mezza classifica: " + cibiPrefe[cibiPrefe.Length / 2]);
} else
{
    Console.WriteLine("Cibi di mezza classifica: ");
    Console.WriteLine("1. " + cibiPrefe[cibiPrefe.Length / 2 - 1]);
    Console.WriteLine("2. " + cibiPrefe[cibiPrefe.Length / 2]);
}
