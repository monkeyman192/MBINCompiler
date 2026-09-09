namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB350CFAC2E9302E, NameHash = 0xD6B84E34)]
    public class GcSpacePoiDiscoverySaveData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public ulong PackedData0;
        [NMS(Index = 2)]
        /* 0x08 */ public ulong PackedData1;
        [NMS(Index = 0)]
        /* 0x10 */ public ulong UA;
    }
}
