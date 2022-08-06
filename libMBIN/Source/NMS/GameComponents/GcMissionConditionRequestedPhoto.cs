using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE0B5B6FF79A3E6A9, NameHash = 0x8EC9FC58B2383BF6)]
    public class GcMissionConditionRequestedPhoto : NMSTemplate
    {
        public GcBiomeType Biome;
    }
}
