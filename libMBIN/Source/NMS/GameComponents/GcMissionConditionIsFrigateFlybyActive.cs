using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE7117831F95D5A2, NameHash = 0xCE9968E4A5D8329B)]
    public class GcMissionConditionIsFrigateFlybyActive : NMSTemplate
    {
        /* 0x0 */ public GcFrigateFlybyType FrigateFlybyType;
    }
}
