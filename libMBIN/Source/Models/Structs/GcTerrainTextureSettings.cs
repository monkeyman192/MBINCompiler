using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8)]
    public class GcTerrainTextureSettings : NMSTemplate      // size: 0x400
    {
        public float Brightness;
        public float Contrast;
    }
}
