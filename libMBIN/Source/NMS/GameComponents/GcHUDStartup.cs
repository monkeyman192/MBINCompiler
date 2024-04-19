using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1B2509DD97B1720, NameHash = 0x4B24756D3BA22E88)]
    public class GcHUDStartup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RequiresTechBroken;
        /* 0x10 */ public GcAudioWwiseEvents Audio;
        /* 0x14 */ public float Time;
    }
}
