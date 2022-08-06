using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97582F86CA14661B, NameHash = 0x2F505B818F28B755)]
    public class GcCreatureAttractorComponentData : NMSTemplate
    {
        /* 0x0 */ public bool Universal;
        /* 0x1 */ public bool Static;
        /* 0x4 */ public float ArriveDist;
        // size: 0x2
        public enum AttractorTypeEnum { Food, Harvester }
        /* 0x8 */ public AttractorTypeEnum AttractorType;
    }
}
