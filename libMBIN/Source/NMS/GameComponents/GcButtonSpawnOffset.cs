using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF8722A59DA1A25, NameHash = 0x42A6687A1AF1F42A)]
    public class GcButtonSpawnOffset : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float AngleMax;
        [NMS(Index = 0)]
        /* 0x04 */ public float AngleMin;
        [NMS(Index = 5)]
        /* 0x08 */ public int Count;
        [NMS(Index = 4)]
        /* 0x0C */ public float Facing;
        [NMS(Index = 6)]
        /* 0x10 */ public GcRealityCommonFactions Faction;
        [NMS(Index = 2)]
        /* 0x14 */ public float Offset;
        [NMS(Index = 7)]
        /* 0x18 */ public GcAISpaceshipRoles ShipRole;
        [NMS(Index = 3)]
        /* 0x1C */ public float Spacing;
    }
}
