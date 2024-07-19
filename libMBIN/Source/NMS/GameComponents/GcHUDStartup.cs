using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA75BE02824EBC401, NameHash = 0xFE3BE144)]
    public class GcHUDStartup : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 RequiresTechBroken;
        [NMS(Index = 0)]
        /* 0x10 */ public GcAudioWwiseEvents Audio;
        [NMS(Index = 1)]
        /* 0x14 */ public float Time;
    }
}
