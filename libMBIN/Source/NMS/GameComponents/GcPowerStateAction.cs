using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2, GUID = 0x3A8E391D0034FCAB, NameHash = 0xAE81DAC6053A1B32)]
    public class GcPowerStateAction : NMSTemplate
    {
        public bool SetRateEnabled;
        public bool SetConnectionEnabled;
    }
}
