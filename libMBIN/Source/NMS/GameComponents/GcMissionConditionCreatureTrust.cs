using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED930A4D356CB06D, NameHash = 0x28316096AAF55A2F)]
    public class GcMissionConditionCreatureTrust : NMSTemplate
    {
        /* 0x0 */ public float Trust;
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
