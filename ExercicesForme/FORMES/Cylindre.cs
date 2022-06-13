

namespace ExercicesForme.FORMES
{
    internal class Cylindre : Forme
    {
        private float _Rayon { get; set; }
        private float _Hauteur { get; set; }    




        public Cylindre(float rayon, float hauteur, float x, float y, float z, string couleur) : base(x, y, z, couleur)
        {
            if (rayon <= 0 || hauteur <= 0) { new Exception("les valeurs ne peuvent etre null"); }
            _Rayon = rayon;
            _Hauteur = hauteur;

            SetVolume((PI * _Rayon * _Rayon) * _Hauteur);

        }
        public float GetRayon()
        {
            return _Rayon;
        }
        public float GetHauteur()
        {
            return _Hauteur;
        }
        //public override void Scale(float scale)
        //{
        //    SetVolume(((PI * _Rayon * _Rayon) * _Hauteur)*scale);
        //}
    }
}
