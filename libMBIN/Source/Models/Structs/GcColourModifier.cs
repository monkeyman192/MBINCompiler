namespace libMBIN.Models.Structs
{
    public class GcColourModifier : NMSTemplate
    {
        public bool ForceColour;
        [NMS(Size = 0xF, Ignore = true)]
        public byte[] Padding1;
        public Colour ForceColourTo;
        public float OffsetSaturation;
        public float OffsetValue;
        public float MultiplySaturation;
        public float MultiplyValue;
    }
}
