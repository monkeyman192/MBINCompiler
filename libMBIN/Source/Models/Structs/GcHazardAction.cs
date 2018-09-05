namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10)]
    public class GcHazardAction : NMSTemplate
    {
        public GcHazardModifiers Hazard;
        public float Strength;
        public float Radius;
        public bool RadiusBasedStrength;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
