using Projekt_21_Dni;
using System.Linq;

int nr = 1;
int best = 0;
string name = "";
string surname = "";
string[] truck = { "Grand Prix Australii", "Grand Prix Maroka", "Grand Prix Wielkiej Brytanii", "Grand Prix Australii", "Grand Prix Europy" };

Console.WriteLine("==================================================");
Console.WriteLine("\tFormula 1 Statystyki Zawodnikow\t");
Console.WriteLine("==================================================");

List<RacerInFile> racers = new List<RacerInFile>();

racers.Add(new RacerInFile(1,"Max","Verstappen",25));
racers.Add(new RacerInFile(2,"Charles", "Leclerc", 25));
racers.Add(new RacerInFile(3,"Fernando", "Alonso", 41));
racers.Add(new RacerInFile(4,"Carlos", "Sainz", 28));
racers.Add(new RacerInFile(5,"Lewis", "Hamilton", 38));
racers.Add(new RacerInFile(6,"Robert", "Kubica", 38));
racers.Add(new RacerInFile(7,"Oscar", "Piastri", 21));
racers.Add(new RacerInFile(8,"Lando", "Norris", 23));
racers.Add(new RacerInFile(9,"Michael", "Schumacher", 54));
racers.Add(new RacerInFile(10, "Sebastian", "Vettel", 35));
racers.Add(new RacerInFile(11, "George", "Russell", 25));


Console.WriteLine("==================================================");
Console.WriteLine("\tLista Kierowcow F1:\t\n");

foreach (var racer in racers)
{
    Console.WriteLine(nr + "." + racer.Name + " \t " + racer.Surname + " \t " + racer.Age);
    nr++;
}
Console.WriteLine("==================================================");

Random rand = new Random();

foreach (var item in truck)
{
    Console.WriteLine("==================================================");
    Console.WriteLine($"\t{item}\t");
    Console.WriteLine("==================================================");

    for (int nr_place = 1; nr_place <= 11; nr_place++)
    {
        List<int>random = new List<int>();
        
        while (random.Count != 11)
        {
            int id = rand.Next(0, 11);
            if (random.Contains(id))
            {
                continue;
            }
            else
            {
                random.Add(id);
                Console.WriteLine($"{nr_place} miejsce: " + racers[id].Name + " " + racers[id].Surname);
                racers[id].AddPlace(nr_place);
                nr_place++;

            }

        }
    }
}

Console.WriteLine("==================================================");
Console.WriteLine($"\tStatystyki Zawodnkow F1\t");
Console.WriteLine("==================================================");

foreach (var racer in racers)
{
    var stat = racer.GetStatistics();
    Console.WriteLine(racer.Id + ". " + racer.Name + " " + racer.Surname + " \t" + stat.Min + "\t" + stat.Max + "\t" + stat.Sum + "\t" + stat.Average);
    Console.WriteLine("----------------------------------------------");
    
    if (stat.Sum > best)
    {
        name = racer.Name;
        surname = racer.Surname;
        best = stat.Sum;
    }
}

Console.WriteLine("==================================================");
Console.WriteLine($"\tZwyciesca: {name}\t{surname}");
Console.WriteLine("==================================================");







