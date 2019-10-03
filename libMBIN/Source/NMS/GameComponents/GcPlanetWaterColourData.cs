using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x4DDC814768F6A7A4, NameHash = 0x5148874790D0404C)]
    public class GcPlanetWaterColourData : NMSTemplate
    {
        public Colour WaterFogColourNear;
        public Colour WaterFogColourFar;
        public Colour WaterColourBase;
        public Colour WaterColourAdd;
        public Colour FoamColour;
    }
}
