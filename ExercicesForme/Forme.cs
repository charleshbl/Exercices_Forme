using ExercicesForme.COULEURS;

namespace ExercicesForme
{
    public abstract class Forme : Points3D
    {
        public const float PI = 3.1416F;
        private float _volume;
        private Couleur _couleur = new Couleur();


        protected Forme(float x, float y, float z, string couleur) : base(x, y, z)
        {
            SetNomCouleur(couleur);
        }

        public void SetNomCouleur(string couleur) => _couleur.SetNomCouleur(couleur);
        public string GetNomCouleur() => _couleur.GetNomCouleur();
        public string GetRGB()
        {
            return $"{_couleur.GetRed()}  {_couleur.GetGreen()}  {_couleur.GetBlue()}";
        }

        // Accesseur --> Access Accéder/Récupérer valeur
        public float GetVolume()
        {
            return _volume;
        }

        // mutateur --> muter un valeur , changer une valeur (pour variable private)
        public void SetVolume(float volume)
        {
            if (volume != 0)
            {
                _volume = volume;
            }
        }

        public void Scale(float scale) { SetVolume(GetVolume() * scale); }

        public void Avancer(int amount)
        {
            SetPosition(GetX() + amount, GetY(), GetZ());
        }


    }
}
