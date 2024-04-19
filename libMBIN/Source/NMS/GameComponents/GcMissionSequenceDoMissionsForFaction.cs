using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52E3FBD9785DC628, NameHash = 0xBDA9289A7DF468BD)]
    public class GcMissionSequenceDoMissionsForFaction : NMSTemplate
    {
        /* 0x00 */ public GcFactionSelectOptions SelectFrom;
        /* 0x08 */ public int AmountMax;
        /* 0x0C */ public int AmountMin;
        /* 0x10 */ public NMSString0x80 DebugText;
        /* 0x90 */ public NMSString0x80 Message;
    }
}
