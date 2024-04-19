using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DE689A3CE5820D3, NameHash = 0x10BF10453E33157C)]
    public class GcMissionSequenceWaitForFactionStanding : NMSTemplate
    {
        /* 0x00 */ public GcFactionSelectOptions SelectFrom;
        /* 0x08 */ public int AmountMax;
        /* 0x0C */ public int AmountMin;
        /* 0x10 */ public NMSString0x80 DebugText;
        /* 0x90 */ public NMSString0x80 Message;
    }
}
