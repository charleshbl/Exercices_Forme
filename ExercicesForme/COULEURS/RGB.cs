using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesForme.COULEURS
{
    public abstract class RGB 
    {
        public float R;
        public float G;
        public float B;

        
        public void SetRGB(float r,float g,float b) { R = r; G = g; B = b; }
        public float GetRed() { return R; }
        public float GetGreen() { return G; }
        public float GetBlue() { return B; }

       
    }
}
