using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52E3FBD9785DC628, NameHash = 0xBDA9289A7DF468BD)]
    public class GcMissionSequenceDoMissionsForFaction : NMSTemplate
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
