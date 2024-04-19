using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEB8071F61919F1E, NameHash = 0x5E041EB212BC9D8D)]
    public class GcMissionConditionPlanetStatLevel : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Stat;
        /* 0x10 */ public ulong SpecificUA;
        /* 0x18 */ public int Amount;
        /* 0x1C */ public TkEqualityEnum Test;
        /* 0x20 */ public bool CalculateUAFromMilestoneIndex;
        /* 0x21 */ public bool CalculateUAFromSeasonData;
        /* 0x22 */ public bool TakeAmountFromSeasonData;
        /* 0x23 */ public bool UseCurrentUA;
    }
}
