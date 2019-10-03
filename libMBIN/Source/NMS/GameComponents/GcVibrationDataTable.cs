using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBC85ABEB3265185B, NameHash = 0x75E1ADCE47B381E6)]
    public class GcVibrationDataTable : NMSTemplate
    {
        public List<GcVibrationChannelData> Data;
    }
}
