

namespace ExercicesForme.FORMES
{
    internal class Cube : Forme
    {
        private float _arrete = 1;
      
       


        public Cube(float arrete, float x, float y, float z, string couleur) : base(x, y, z, couleur)
        {

            if (arrete <= 0)
            {
                throw new Exception("La longeur du cote du cube ne peu etre NULL  ");
            }
            else
                SetArrete(arrete);
            SetVolume(_arrete * _arrete * _arrete);
        
            


        }
        //public override void Scale(float scale)
        //{
        //    SetVolume(GetVolume()*scale);
        //}

        public float GetArrete() { return _arrete; }

        public void SetArrete(float arrete) { _arrete = arrete; }
    }
}
