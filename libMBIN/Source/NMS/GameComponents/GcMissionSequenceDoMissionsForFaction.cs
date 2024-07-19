using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95533AA45ECAB1D9, NameHash = 0x7571A759)]
    public class GcMissionSequenceDoMissionsForFaction : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public GcFactionSelectOptions SelectFrom;
        [NMS(Index = 3)]
        /* 0x28 */ public int AmountMax;
        [NMS(Index = 2)]
        /* 0x2C */ public int AmountMin;
    }
}
