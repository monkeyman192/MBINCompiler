using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xDDF10BFCF81EB27B, NameHash = 0xB2E60FCA3C5550F9)]
    public class GcWaterColourSettingList : NMSTemplate
    {
        public List<GcPlanetWaterColourData> Settings;
    }
}
