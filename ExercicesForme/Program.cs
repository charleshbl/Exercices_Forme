using ExercicesForme;
using ExercicesForme.FORMES;



List<Forme> lsForme3d = new List<Forme>();

//Toutes les formes ont une taille par défaut, a vous de choisir
lsForme3d.Add(new Sphere(rayon: .75F, x: 1, y: 1, z: 1, couleur: "Rouge"));
lsForme3d.Add(new Cylindre(rayon: 2, hauteur: 2, x: 3, y: 3, z: 3, couleur: "Vert"));
lsForme3d.Add(new Cube(arrete: 1.5F, x: 2, y: 2, z: 2, couleur: "Bleu"));
lsForme3d.Add(new Cylindre(rayon: 3, hauteur: 3, x: 4, y: 4, z: 4, couleur: "Rouge"));

for (int i = 0; i < lsForme3d.Count; ++i)
{
    Console.WriteLine($"Volume forme {i}: {lsForme3d[i].GetVolume()}");
    lsForme3d[i].Scale(2); // multiplie par 2 dans ce cas ci
    Console.WriteLine($"Volume forme {i} après scale: {lsForme3d[i].GetVolume()}");
}


Console.WriteLine(value: $"Quel forme voulez-vous bouger? (min 0, max {lsForme3d.Count - 1})");



ConsoleKeyInfo key = Console.ReadKey();
while (key.Key != ConsoleKey.Enter)
{
    var NB = Convert.ToInt32(key.KeyChar.ToString());

    Console.WriteLine($"vous avez ecrit  {NB}");


    lsForme3d[NB].Avancer(4);
    Console.WriteLine($"{lsForme3d[NB].GetPosition()} volume;{lsForme3d[NB].GetVolume()} {lsForme3d[NB].GetNomCouleur()}");
    Console.WriteLine($"Bouger encore une forme ? (min 0, max {lsForme3d.Count - 1})");
    Console.WriteLine("Ou presser ENTER pour Quitter");
    key = Console.ReadKey();
}



