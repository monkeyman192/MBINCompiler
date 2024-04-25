using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEB8071F61919F1E, NameHash = 0x5E041EB212BC9D8D)]
    public class GcMissionConditionPlanetStatLevel : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Stat;
        [NMS(Index = 2)]
        /* 0x10 */ public ulong SpecificUA;
        [NMS(Index = 1)]
        /* 0x18 */ public int Amount;
        [NMS(Index = 7)]
        /* 0x1C */ public TkEqualityEnum Test;
        [NMS(Index = 5)]
        /* 0x20 */ public bool CalculateUAFromMilestoneIndex;
        [NMS(Index = 4)]
        /* 0x21 */ public bool CalculateUAFromSeasonData;
        [NMS(Index = 6)]
        /* 0x22 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 3)]
        /* 0x23 */ public bool UseCurrentUA;
    }
}
