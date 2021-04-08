using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xA8828B0BD2D0CD65, NameHash = 0x9699B119759C861B)]
    public class GcPlayerHazardType : NMSTemplate
    {
        public enum HazardEnum { None, NoOxygen, ExtremeHeat, ExtremeCold, ToxicGas, Radiation }
        public HazardEnum Hazard;
    }
}