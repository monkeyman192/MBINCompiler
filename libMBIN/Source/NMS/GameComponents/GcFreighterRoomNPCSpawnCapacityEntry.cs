using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15A0D9B1A76B7040, NameHash = 0x990CE1CD4E45ADF3)]
    public class GcFreighterRoomNPCSpawnCapacityEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RoomID;
        /* 0x10 */ public float SpawnCapacity;
    }
}
