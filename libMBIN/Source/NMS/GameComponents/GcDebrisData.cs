using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56FACB1782B83DCF, NameHash = 0x99BAD1E4)]
    public class GcDebrisData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource Filename;
        [NMS(Index = 6)]
        /* 0x18 */ public GcSeed OverrideSeed;
        [NMS(Index = 5)]
        /* 0x28 */ public float AnglularSpeed;
        [NMS(Index = 1)]
        /* 0x2C */ public int Number;
        [NMS(Index = 2)]
        /* 0x30 */ public float Radius;
        [NMS(Index = 3)]
        /* 0x34 */ public float Scale;
        [NMS(Index = 4)]
        /* 0x38 */ public float Speed;
    }
}
