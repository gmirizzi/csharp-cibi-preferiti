string[] cibiPrefe = { "Pizza", "Patata", "Panzerotto", "Pasta", "Carne", "Pesce", "Parmigiana" };
Console.WriteLine($"La lunghezza della classifica è pari a {cibiPrefe.Length}");
Console.WriteLine("Classifica dei cibi preferiti:");
for (int i = 0; i < cibiPrefe.Length; i++)
{
    Console.WriteLine($"{i+1}. {cibiPrefe[i]}");
}
Console.WriteLine("Cibo top: " + cibiPrefe[0]);


