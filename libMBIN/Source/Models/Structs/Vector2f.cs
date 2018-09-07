namespace libMBIN.Models.Structs
{
    public class Vector2f : NMSTemplate
    {
        public float x;
        public float y;

        public Vector2f(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2f() { }
    }
}
