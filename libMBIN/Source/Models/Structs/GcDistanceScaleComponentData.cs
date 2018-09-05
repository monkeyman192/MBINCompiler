namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x18)]
    public class GcDistanceScaleComponentData : NMSTemplate
    {
        public bool UseGlobals;
        public float Scale;
        public float MinDistance;
        public float MaxDistance;
        public float MinHeight;
        public float MaxHeight;
        public bool DisabledWhenOnFreighter;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
