using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CD5C466CB533C0A, NameHash = 0xB387E3560FAA5681)]
    public class GcDamageMultiplier : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Multiplier;
        [NMS(Index = 0)]
        /* 0x4 */ public GcDamageType Type;
    }
}
