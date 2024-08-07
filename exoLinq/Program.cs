

using exoLinq;


List<Personne> persone = new()
{
    new() { Nom = "Dupont", PreNom ="Jean",TailleCm = 175, Genres = Genre.Homme  },
    new() { Nom = "Dupont", PreNom ="Jeanne",TailleCm = 156, Genres = Genre.Femme  },
    new() { Nom = "Durand", PreNom ="Marc",TailleCm = 192, Genres = Genre.Homme, DateDeNaissance = new(1999, 10, 5) },
    new() { Nom = "Thomas", PreNom ="Gérard",TailleCm = 182, Genres = Genre.Homme  },
    new() { Nom = "Mommer", PreNom ="Megane",TailleCm = 169, Genres = Genre.Femme, DateDeNaissance = new(1966, 12, 25) },
     new() { Nom = "Mommer", PreNom ="Christope",TailleCm = 180, Genres = Genre.Homme, DateDeNaissance = new(1988, 9, 5) }
};

List<string> nomsDeFamille = persone.Select(p => p.Nom).ToList();

foreach (var item in nomsDeFamille)
{
    Console.WriteLine(item);
}

var personAvecDateDeNissance = persone.Where(p => p.DateDeNaissance.HasValue);

foreach (var item in personAvecDateDeNissance)
{
    Console.WriteLine($"né le {item.DateDeNaissance!.Value:dd/MM/yyyy}");
}

var exsisteUneFemme = persone.Any(p => p.Genres == Genre.Femme);


Console.WriteLine(exsisteUneFemme);

var nomPlusDeTroiChar = persone.All(p => p.Nom.Length > 6);

Console.WriteLine(nomPlusDeTroiChar);

var triNom = persone.OrderBy(p => p.Nom).ThenBy(p => p.PreNom);

foreach (var item in triNom)
{
    Console.WriteLine($"{item.Nom} et {item.PreNom}");
}
