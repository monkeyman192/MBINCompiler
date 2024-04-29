namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEB35CEB07B00A11E, NameHash = 0xEC9FF9AD5EDADEFF)]
    public class TkSpeedLineData : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x00 */ public Colour ColourEnd;
        [NMS(Index = 12)]
        /* 0x10 */ public Colour ColourOrigin;
        [NMS(Index = 6)]
        /* 0x20 */ public float Alpha;
        [NMS(Index = 7)]
        /* 0x24 */ public float FadeTime;
        [NMS(Index = 3)]
        /* 0x28 */ public float Length;
        [NMS(Index = 10)]
        /* 0x2C */ public float Lifetime;
        // size: 0x2
        public enum LinesPositionEnum : uint {
            Absolute,
            Relative,
        }
        [NMS(Index = 14)]
        /* 0x30 */ public LinesPositionEnum LinesPosition;
        [NMS(Index = 9)]
        /* 0x34 */ public float MaxVisibleSpeed;
        [NMS(Index = 8)]
        /* 0x38 */ public float MinVisibleSpeed;
        [NMS(Index = 1)]
        /* 0x3C */ public int NumberOfParticles;
        [NMS(Index = 2)]
        /* 0x40 */ public float Radius;
        [NMS(Index = 4)]
        /* 0x44 */ public float RemoveCylinderRadius;
        [NMS(Index = 11)]
        /* 0x48 */ public float Speed;
        [NMS(Index = 5)]
        /* 0x4C */ public float Width;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x80 Material;
    }
}
