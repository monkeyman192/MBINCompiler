using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9146AAAE645DEC, NameHash = 0x386029983CBEF506)]
    public class GcPlayerStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcStatValueData Value;
    }
}
