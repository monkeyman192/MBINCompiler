using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCDC0444569389B85, NameHash = 0x880E3ABD8848E698)]
    public class GcGalacticAddressData : NMSTemplate // 0x14 bytes
    {
        public int VoxelX;

        public int VoxelY;

        public int VoxelZ;

        public int SolarSystemIndex;

        public int PlanetIndex;
    }
}
