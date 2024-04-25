using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD16BDF2B722D86A9, NameHash = 0xC9F6512AC970CD07)]
    public class GcDebrisData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public GcSeed OverrideSeed;
        [NMS(Index = 0)]
        /* 0x10 */ public TkModelResource Filename;
        [NMS(Index = 5)]
        /* 0x94 */ public float AnglularSpeed;
        [NMS(Index = 1)]
        /* 0x98 */ public int Number;
        [NMS(Index = 2)]
        /* 0x9C */ public float Radius;
        [NMS(Index = 3)]
        /* 0xA0 */ public float Scale;
        [NMS(Index = 4)]
        /* 0xA4 */ public float Speed;
    }
}
