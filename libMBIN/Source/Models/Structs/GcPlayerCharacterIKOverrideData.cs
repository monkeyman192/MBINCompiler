namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcPlayerCharacterIKOverrideData : NMSTemplate
    {
        public bool Enabled;
        public float Strength;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding8;
        public Vector4f RotStrengths;
    }
}
