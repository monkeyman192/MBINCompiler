using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x97582F86CA14661B, NameHash = 0x2F505B818F28B755)]
    public class GcCreatureAttractorComponentData : NMSTemplate
    {
        public bool Universal;
        public bool Static;
        public float ArrivalDist;
        public enum AttractorTypeEnum { Food, Harvester }
        public AttractorTypeEnum AttractorType;
    }
}
