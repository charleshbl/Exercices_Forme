

namespace ExercicesForme;

internal class Scène
{
   public List<Forme> LsFormes = new();
   
    public void AddCube(int Nbr,float arete, float x, float y, float z) 
    {
        for (int i = 0; i < Nbr; i++)
        {
            LsFormes.Add(new FORMES.Cube(arete, x, y, z, "Rouge"));
        }
    }
    public void AddSphere(int Nbr, float rayon, float x, float y, float z)
    {
        for (int i = 0; i < Nbr; i++)
        {
            LsFormes.Add(new FORMES.Sphere(rayon, x, y, z, "Rouge"));
        }
    }
    public void AddCylindre(int Nbr, float rayon,float hauteur, float x, float y, float z)
    {
        for (int i = 0; i < Nbr; i++)
        {
            LsFormes.Add(new FORMES.Cylindre(rayon,hauteur, x, y, z, "Rouge"));
        }
    }
    public Scène(int NbDeCube, int NbDeSphere, int nbCylindre)
    {
        
        for (int i = 0; i < NbDeCube; i++)
        {
            LsFormes.Add(new FORMES.Cube(arrete:1+ i*0.75F, x: 1 + i, y: 1, z: 1,couleur:"Rouge"));
        }
         for (int i = 0; i < NbDeSphere; i++)
        {
            LsFormes.Add(new FORMES.Sphere(rayon:1+ i * 0.5F, x: 1 + i, y: 2, z: 1, couleur:"Vert" ));
        }
         for(int i = 0; i < nbCylindre; i++)
        {
            LsFormes.Add(new FORMES.Cylindre(rayon: 1 + i * .25F, hauteur: 1 + i * .5F, x: 1 + i , y: 3, z: 1, couleur:"Bleu"));
        }

       

         



    }

}
