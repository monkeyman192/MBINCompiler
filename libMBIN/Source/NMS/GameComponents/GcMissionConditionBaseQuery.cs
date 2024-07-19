using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD4714A46700C4F06, NameHash = 0x67438A8B)]
    public class GcMissionConditionBaseQuery : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcBaseSearchFilter BaseSearchFilter;
        [NMS(Index = 2)]
        /* 0x98 */ public int MaxBasesFound;
        [NMS(Index = 1)]
        /* 0x9C */ public int MinBasesFound;
        [NMS(Index = 3)]
        /* 0xA0 */ public float SearchDistanceLimit;
        [NMS(Index = 4)]
        /* 0xA4 */ public bool TakeSpecificPartIdFromSeasonData;
    }
}
