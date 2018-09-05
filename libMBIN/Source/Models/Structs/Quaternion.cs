namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x10)]
    public class Quaternion : NMSTemplate
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public Quaternion(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
}
