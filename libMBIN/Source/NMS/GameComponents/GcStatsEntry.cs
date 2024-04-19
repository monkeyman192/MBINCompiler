using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB353F457EF11C4EF, NameHash = 0x4309D65C13EEC689)]
    public class GcStatsEntry : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public NMSString0x10 BaseTechID;
        /* 0x20 */ public float RangeMax;
        /* 0x24 */ public float RangeMin;
        /* 0x28 */ public GcStatsTypes Type;
        /* 0x2C */ public bool LessIsBetter;
    }
}
