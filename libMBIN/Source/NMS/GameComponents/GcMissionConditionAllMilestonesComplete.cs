using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x124458932833A2E6, NameHash = 0x088DB4BD2401DF5D)]
    public class GcMissionConditionAllMilestonesComplete : NMSTemplate
    {
        public int ForStage;
        public bool UseSeasonOverrideMessage;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
