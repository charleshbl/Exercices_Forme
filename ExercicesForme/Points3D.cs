namespace ExercicesForme
{
    public class Points3D 
    {

        private float _X { get; set; }
        private float _Y { get; set; }
        private float _Z { get; set; }
       


        

       //// public Points3D() { }
         public Points3D(float x, float y, float z)
         {
             _X = x;
             _Y = y;
             _Z = z;
         }
        public void SetPosition(float x,float y,float z) { _X = x; _Y = y; _Z = z; }
        public float GetX() { return _X; }
        public float GetY() { return _Y; }
        public float GetZ() { return _Z; }

        public string GetPositionTXT() { return $"X={GetX()}Y={GetY()}X={GetZ()}"; }


    }
}