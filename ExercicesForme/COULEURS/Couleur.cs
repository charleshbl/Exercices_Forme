namespace ExercicesForme.COULEURS
{
    public class Couleur : RGB
    {
        public string _NomCouleur = "";
        public const string _Rouge = "Rouge";
        public const string _Vert = "Vert";
        public const string _Bleu = "Bleu";


        public void SetNomCouleur(string couleur) { _NomCouleur = couleur; }
        public string GetNomCouleur() { return _NomCouleur; }


        public Couleur()
         {
             
        
             if (_NomCouleur == null) { throw new ArgumentNullException(nameof(_NomCouleur)); }
             else if (_NomCouleur == _Rouge)
             {
              
               SetRGB(255, 0, 0);
             }
             else if (_NomCouleur == _Vert)
             {
                 
               SetRGB(0, 255, 0);                 
             }
             else 
             {
                
               SetRGB(0, 0, 255); 
             }
             
         }
    }
}