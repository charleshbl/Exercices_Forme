

namespace ExercicesForme;

internal class Scène
{
    
    public Scène(int NbDeCube, int NbDeSphere, int nbCylindre)
    {
        List<Forme> LsFormes = new();
        for (int i = 0; i < NbDeCube; i++)
        {
            LsFormes.Add(new FORMES.Cube(arrete: i*0.75F, x: 1 + i, y: 1, z: 1,couleur:"Rouge"));
        }
         for (int i = 0; i < NbDeSphere; i++)
        {
            LsFormes.Add(new FORMES.Sphere(rayon:1+ i * 0.5F, x: 1 + i, y: 2, z: 1, couleur:"Vert" ));
        }
         for(int i = 0; i < nbCylindre; i++)
        {
            LsFormes.Add(new FORMES.Cylindre(rayon: 1 + i * .25F, hauteur: 1 + i * .5F, x: 1 + i , y: 3, z: 1, couleur:"Bleu"));
        }

       int NbrObjets3D() { return LsFormes.Count; }

         



    }

}
