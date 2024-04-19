namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B0E6131C007BCD, NameHash = 0x9C1F12F64375236D)]
    public class GcBuildingSpawnSlot : NMSTemplate
    {
        /* 0x0 */ public int BuildingDataIndex;
        /* 0x4 */ public float Probability;
        /* 0x8 */ public bool HasBuilding;
    }
}
