using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67F87561F25DD6A0, NameHash = 0x891EECEF6BD18108)]
    public class GcMissionConditionFeedingCreatures : NMSTemplate
    {
        /* 0x0 */ public int MinCreatures;
        /* 0x4 */ public bool TakeNumFromSeasonData;
    }
}
