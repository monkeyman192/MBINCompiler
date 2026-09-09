using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC700D02484A2413, NameHash = 0xC3CD194A)]
    public class GcRecyclerComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 PlayerDamage;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 RecycleEffect;
        [NMS(Index = 4)]
        /* 0x20 */ public float HoldTime;
        [NMS(Index = 0)]
        /* 0x24 */ public GcRecyclableType RecycleType;
        [NMS(Index = 1)]
        /* 0x28 */ public GcInventoryChoice RewardInventoryOverride;
    }
}
