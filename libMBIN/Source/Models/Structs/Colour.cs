namespace libMBIN.Models.Structs
{
    public class Colour : NMSTemplate
    {
        public float R;
        public float G;
        public float B;
        public float A;

        public Colour(float R, float G, float B, float A)
        {
            this.R = R;
            this.G = G;
            this.B = B;
            this.A = A;
        }

        public Colour() { }
    }
}
