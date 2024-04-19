namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE445E4110EBDBDAC, NameHash = 0xEC9FF9AD5EDADEFF)]
    public class TkSpeedLineData : NMSTemplate
    {
        /* 0x00 */ public Colour ColourEnd;
        /* 0x10 */ public Colour ColourOrigin;
        /* 0x20 */ public float Alpha;
        /* 0x24 */ public float FadeTime;
        /* 0x28 */ public float Length;
        /* 0x2C */ public float Lifetime;
        // size: 0x2
        public enum LinesPositionEnum : uint {
            Absolute,
            Relative,
        }
        /* 0x30 */ public LinesPositionEnum LinesPosition;
        /* 0x34 */ public float MaxVisibleSpeed;
        /* 0x38 */ public float MinVisibleSpeed;
        /* 0x3C */ public int NumberOfParticles;
        /* 0x40 */ public float Radius;
        /* 0x44 */ public float RemoveCylinderRadius;
        /* 0x48 */ public float Speed;
        /* 0x4C */ public float Width;
        /* 0x50 */ public NMSString0x80 Material;
    }
}
