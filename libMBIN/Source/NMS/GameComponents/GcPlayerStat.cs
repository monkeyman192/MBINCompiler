using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x286062CC2E2134CF, NameHash = 0x4731E188)]
    public class GcPlayerStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public GcStatValueData Value;
    }
}
