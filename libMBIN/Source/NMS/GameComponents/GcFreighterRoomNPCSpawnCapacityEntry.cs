namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84636CEB90E27C40, NameHash = 0xFC96930E)]
    public class GcFreighterRoomNPCSpawnCapacityEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 RoomID;
        [NMS(Index = 1)]
        /* 0x10 */ public float SpawnCapacity;
    }
}
