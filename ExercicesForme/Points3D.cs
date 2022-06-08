namespace ExercicesForme
{
    public class Points3D 
    {

        private float _X;
        private float _Y;
        private float _Z;
       

        public void SetPosition(float x,float y,float z) { _X = x; _Y = y; _Z = z; }
        public float GetX() { return _X; }
        public float GetY() { return _Y; }
        public float GetZ() { return _Z; }

        public string GetPosition() { return $"X={GetX()}Y={GetY()}X={GetZ()}"; }


       //// public Points3D() { }
         public Points3D(float x, float y, float z)
         {
             _X = x;
             _Y = y;
             _Z = z;
         }
    }
}