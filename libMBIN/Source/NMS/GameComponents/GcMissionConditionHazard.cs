using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x55CF84CE9909757A, NameHash = 0xBEE9A9FF61C9FEFB)]
    public class GcMissionConditionHazard : NMSTemplate
    {
        public GcPlayerHazardType Hazard;
    }
}
