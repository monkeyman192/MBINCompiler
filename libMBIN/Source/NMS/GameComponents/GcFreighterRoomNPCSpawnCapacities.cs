using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA461AD798F8E00FD, NameHash = 0xF9AE5C7D267CB35F)]
    public class GcFreighterRoomNPCSpawnCapacities : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFreighterRoomNPCSpawnCapacityEntry> RoomSpawnCapacities;
    }
}
