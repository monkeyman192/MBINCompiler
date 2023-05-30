using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcBuildingDensity : NMSTemplate // 0x14 bytes
    {
        public float BuildingSpacing;
        public float BuildingClusterChance1; // todo: change this to float[]
        public float BuildingClusterChance2;
        public float BuildingClusterChance3;
        public float BuildingClusterChance4;
    }
}
