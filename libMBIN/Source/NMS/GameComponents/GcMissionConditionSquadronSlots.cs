using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50C3287187DF1056, NameHash = 0xA1BAA7B81B1B5EF4)]
    public class GcMissionConditionSquadronSlots : NMSTemplate
    {
        /* 0x0 */ public int PilotSlots;
        /* 0x4 */ public TkEqualityEnum Test;
        /* 0x8 */ public bool OnlyCountFreeSlots;
        /* 0x9 */ public bool TakeNumberFromSeasonData;
    }
}
