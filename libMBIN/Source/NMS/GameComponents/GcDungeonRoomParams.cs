namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1D4FB10703606E5, NameHash = 0xA2ECE651D48EE56D)]
    public class GcDungeonRoomParams : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 RoomId;
        [NMS(Index = 1)]
        /* 0x10 */ public float BranchProbability;
    }
}
