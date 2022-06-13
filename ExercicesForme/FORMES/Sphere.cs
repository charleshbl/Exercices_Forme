using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesForme.FORMES
{
    internal class Sphere : Forme
    {
        private float _rayon { get; set; }
       
       

        public Sphere(float rayon, float x, float y, float z, string couleur) : base (x,y, z, couleur)
        {
          

            if (rayon <= 0) { throw new Exception("Le rayon ne peu etre NULL"); }
            _rayon = rayon;
            SetVolume((4 * PI * (_rayon * _rayon * _rayon)) / 3);
            
            
        }

        //public override void Scale(float scale)
        //{
        //    _rayon *= scale;
        //    SetVolume((4 * PI * (_rayon * _rayon * _rayon)) / 3);
        //}

        public float GetRayon() { return _rayon; }
        public void SetRayon(float rayon) { _rayon = rayon; }
    }
}
