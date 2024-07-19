namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x98864004439E76CE, NameHash = 0x1145CAF4)]
    public class TkSpeedLineData : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x00 */ public Colour ColourEnd;
        [NMS(Index = 12)]
        /* 0x10 */ public Colour ColourOrigin;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Material;
        [NMS(Index = 6)]
        /* 0x30 */ public float Alpha;
        [NMS(Index = 7)]
        /* 0x34 */ public float FadeTime;
        [NMS(Index = 3)]
        /* 0x38 */ public float Length;
        [NMS(Index = 10)]
        /* 0x3C */ public float Lifetime;
        // size: 0x2
        public enum LinesPositionEnum : uint {
            Absolute,
            Relative,
        }
        [NMS(Index = 14)]
        /* 0x40 */ public LinesPositionEnum LinesPosition;
        [NMS(Index = 9)]
        /* 0x44 */ public float MaxVisibleSpeed;
        [NMS(Index = 8)]
        /* 0x48 */ public float MinVisibleSpeed;
        [NMS(Index = 1)]
        /* 0x4C */ public int NumberOfParticles;
        [NMS(Index = 2)]
        /* 0x50 */ public float Radius;
        [NMS(Index = 4)]
        /* 0x54 */ public float RemoveCylinderRadius;
        [NMS(Index = 11)]
        /* 0x58 */ public float Speed;
        [NMS(Index = 5)]
        /* 0x5C */ public float Width;
    }
}
