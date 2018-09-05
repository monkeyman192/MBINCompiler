using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x0C)]
    public class GcBuildingSpawnSlot : NMSTemplate
    {
        public bool HasBuilding;
        public int BuildingDataIndex;
        public float Probability;
    }
}
