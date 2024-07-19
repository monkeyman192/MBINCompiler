using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2218FCD30962AB80, NameHash = 0xF273F6C7)]
    public class GcMissionConditionBasePartsQuery : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcBaseSearchFilter ExcludeBasesFilter;
        [NMS(Index = 0)]
        /* 0x98 */ public GcBasePartSearchFilter PartsSearchFilter;
        [NMS(Index = 2)]
        /* 0xE0 */ public int MaxPartsFound;
        [NMS(Index = 1)]
        /* 0xE4 */ public int MinPartsFound;
        [NMS(Index = 5)]
        /* 0xE8 */ public float SearchDistanceLimit;
        [NMS(Index = 4)]
        /* 0xEC */ public bool ExcludeGlobalBuffer;
    }
}
