using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x29490, GUID = 0xE2E881D0E53E1ECC, NameHash = 0xBEAB285DC115E7C6)]
    public class GcInputActionInfoMap : NMSTemplate
    {
        [NMS(Size = 0x10F, EnumType = typeof(GcInputActions.InputActionEnum))]
        public GcInputActionInfo[] ActionMap;
    }
}
