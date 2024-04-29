using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DEAC729A1FB6746, NameHash = 0xA1BAA7B81B1B5EF4)]
    public class GcMissionConditionSquadronSlots : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int PilotSlots;
        [NMS(Index = 2)]
        /* 0x4 */ public TkEqualityEnum Test;
        [NMS(Index = 1)]
        /* 0x8 */ public bool OnlyCountFreeSlots;
        [NMS(Index = 3)]
        /* 0x9 */ public bool TakeNumberFromSeasonData;
    }
}
