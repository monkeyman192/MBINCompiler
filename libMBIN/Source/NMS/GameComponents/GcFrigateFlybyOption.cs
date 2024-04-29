using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43810B8BD003C227, NameHash = 0x7219E3FF7006060F)]
    public class GcFrigateFlybyOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcFrigateClass FrigateClass;
        [NMS(Index = 2)]
        /* 0x4 */ public int MaxCount;
        [NMS(Index = 1)]
        /* 0x8 */ public int MinCount;
        [NMS(Index = 3)]
        /* 0xC */ public float Weight;
    }
}
