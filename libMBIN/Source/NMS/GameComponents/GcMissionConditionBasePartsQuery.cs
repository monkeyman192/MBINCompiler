using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FA6B511C814BF6D, NameHash = 0xDC4640E07A221674)]
    public class GcMissionConditionBasePartsQuery : NMSTemplate
    {
        /* 0x00 */ public GcBaseSearchFilter ExcludeBasesFilter;
        /* 0x98 */ public GcBasePartSearchFilter PartsSearchFilter;
        /* 0xE0 */ public int MaxPartsFound;
        /* 0xE4 */ public int MinPartsFound;
        /* 0xE8 */ public float SearchDistanceLimit;
        /* 0xEC */ public bool ExcludeGlobalBuffer;
    }
}
