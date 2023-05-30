using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkSpeedLineData : NMSTemplate
    {
        public NMSString0x80 Material;
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
        public int LinesPosition;
        public string[] LinesPositionValues()
        {
            return new[] { "Absolute", "Relative" };
        }

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] PaddingD4;
    }
}
