using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x60EED6B341476FB0, NameHash = 0xBCA190142B227B20)]
    public class GcFreighterRoomNPCData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 RoomID;
        [NMS(Index = 2, Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x10 */ public float[] POISelectionWeight;
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x24 */ public float[] SpawnCapacity;
    }
}
