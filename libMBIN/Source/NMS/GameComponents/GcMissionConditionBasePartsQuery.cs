using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x93BA9EBEC20A7A02, NameHash = 0xF273F6C7)]
    public class GcMissionConditionBasePartsQuery : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcBaseSearchFilter ExcludeBasesFilter;
        [NMS(Index = 0)]
        /* 0x0C0 */ public GcBasePartSearchFilter PartsSearchFilter;
        [NMS(Index = 2)]
        /* 0x120 */ public int MaxPartsFound;
        [NMS(Index = 1)]
        /* 0x124 */ public int MinPartsFound;
        [NMS(Index = 5)]
        /* 0x128 */ public float SearchDistanceLimit;
        [NMS(Index = 4)]
        /* 0x12C */ public bool ExcludeGlobalBuffer;
    }
}
