namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xA8)]
    public class GcDebrisData : NMSTemplate
    {
        /* 0x00 */ public TkModelResource Filename;
        /* 0x84 */ public int Number;
        /* 0x88 */ public float Radius;
        /* 0x8C */ public float Scale;
        /* 0x90 */ public float Speed;
        /* 0x94 */ public float AngularSpeed;
        /* 0x98 */ public GcSeed OverrideSeed;
    }
}
