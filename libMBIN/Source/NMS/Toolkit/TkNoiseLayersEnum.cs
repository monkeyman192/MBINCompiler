using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x132E717D078767EE, NameHash = 0xDF72B6BAF8A085A2)]
    public class TkNoiseLayersEnum : NMSTemplate
    {
        // size: 0x8
        public enum NoiseLayerTypesEnum { Base, Hill, Mountain, Rock, UnderWater, Texture, Elevation, Continent };
        public NoiseLayerTypesEnum NoiseLayerTypes;
    }
}
