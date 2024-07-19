namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB860B81940643774, NameHash = 0x3394C00E)]
    public class GcBuildingSpawnSlot : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int BuildingDataIndex;
        [NMS(Index = 2)]
        /* 0x4 */ public float Probability;
        [NMS(Index = 0)]
        /* 0x8 */ public bool HasBuilding;
    }
}
