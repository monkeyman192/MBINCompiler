using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59FD30579560325D, NameHash = 0x47BEA0DB)]
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
