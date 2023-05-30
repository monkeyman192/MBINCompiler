using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcGalacticAddressData : NMSTemplate // 0x14 bytes
    {
        public int VoxelX;

        public int VoxelY;

        public int VoxelZ;

        public int SolarSystemIndex;

        public int PlanetIndex;
    }
}
