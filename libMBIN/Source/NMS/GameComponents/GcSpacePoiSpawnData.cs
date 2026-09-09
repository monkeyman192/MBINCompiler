using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x622FB5ACE58F03EB, NameHash = 0xAC5BB45)]
    public class GcSpacePoiSpawnData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 ItemID;
        [NMS(Index = 0)]
        /* 0x20 */ public ulong Seed;
        [NMS(Index = 5)]
        /* 0x28 */ public int DiscoveryIndex;
        [NMS(Index = 6)]
        /* 0x2C */ public GcSpacePoiDiscoveryLevel InitialDiscoveryLevel;
        [NMS(Index = 3)]
        /* 0x30 */ public int PoiIndex;
        [NMS(Index = 4)]
        /* 0x34 */ public int SunIndex;
    }
}
