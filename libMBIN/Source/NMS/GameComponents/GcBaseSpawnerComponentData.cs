using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7450C6BACED5D3AD, NameHash = 0xF5525C95)]
    public class GcBaseSpawnerComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float BaseSearchRange;
        [NMS(Index = 1)]
        /* 0x4 */ public GcPersistentBaseTypes BaseType;
        [NMS(Index = 2)]
        /* 0x8 */ public float BuildableAreaRange;
    }
}
