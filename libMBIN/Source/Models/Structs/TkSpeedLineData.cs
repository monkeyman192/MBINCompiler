namespace libMBIN.Models.Structs
{
    public class TkSpeedLineData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Material;
        public int NumberOfParticles;
        public float Radius;
        public float Length;
        public float RemoveCylinderRadius;
        public float Width;
        public float Alpha;
        public float FadeTime;
        public float MinVisibleSpeed;
        public float MaxVisibleSpeed;
        public float Lifetime;
        public float Speed;
        public Colour ColourOrigin;
        public Colour ColourEnd;
		public enum LinesPositionEnum { Absolute, Relative }
		public LinesPositionEnum LinesPosition;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] PaddingD4;
    }
}
