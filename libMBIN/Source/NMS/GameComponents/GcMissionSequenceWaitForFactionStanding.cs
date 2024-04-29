using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB2221B55E6EA8CB, NameHash = 0x10BF10453E33157C)]
    public class GcMissionSequenceWaitForFactionStanding : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFactionSelectOptions SelectFrom;
        [NMS(Index = 3)]
        /* 0x08 */ public int AmountMax;
        [NMS(Index = 2)]
        /* 0x0C */ public int AmountMin;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x80 Message;
    }
}
