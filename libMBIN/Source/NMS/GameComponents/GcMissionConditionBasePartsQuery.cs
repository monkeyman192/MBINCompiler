using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x602D7398AEA0B08B, NameHash = 0xDC4640E07A221674)]
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
