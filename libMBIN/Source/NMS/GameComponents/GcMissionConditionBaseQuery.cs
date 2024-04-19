using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F2B92D1DDCF62D3, NameHash = 0xDAD32FDD35922F28)]
    public class GcMissionConditionBaseQuery : NMSTemplate
    {
        /* 0x00 */ public GcBaseSearchFilter BaseSearchFilter;
        /* 0x98 */ public int MaxBasesFound;
        /* 0x9C */ public int MinBasesFound;
        /* 0xA0 */ public float SearchDistanceLimit;
        /* 0xA4 */ public bool TakeSpecificPartIdFromSeasonData;
    }
}
