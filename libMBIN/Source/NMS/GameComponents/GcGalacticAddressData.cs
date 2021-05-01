using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x14, GUID = 0xCDC0444569389B85, NameHash = 0x880E3ABD8848E698)]
    public class GcGalacticAddressData : NMSTemplate
    {
        /* 0x00 */ public int VoxelX;
        /* 0x04 */ public int VoxelY;
        /* 0x08 */ public int VoxelZ;
        /* 0x0C */ public int SolarSystemIndex;
        /* 0x10 */ public int PlanetIndex;
    }
}
