using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD16BDF2B722D86A9, NameHash = 0xC9F6512AC970CD07)]
    public class GcDebrisData : NMSTemplate
    {
        /* 0x00 */ public GcSeed OverrideSeed;
        /* 0x10 */ public TkModelResource Filename;
        /* 0x94 */ public float AnglularSpeed;
        /* 0x98 */ public int Number;
        /* 0x9C */ public float Radius;
        /* 0xA0 */ public float Scale;
        /* 0xA4 */ public float Speed;
    }
}
