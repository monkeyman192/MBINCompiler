using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xE4F65176203E86E1, NameHash = 0x34F3A56DC1D3CE80)]
    public class GcHazardValueTypes : NMSTemplate
    {
        // size = 0x5
        public enum GcHazardValueTypesEnum { Ambient, Water, Cave, Storm, Night };
        /* 0x000 */ public GcHazardValueTypesEnum HazardValue;
    }
}
