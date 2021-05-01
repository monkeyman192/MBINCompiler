using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0xE03A68301E8C7DD3, NameHash = 0x31B74EACF0D0DC1B)]
    public class GcMissionConditionConvertedFromSeason : NMSTemplate
    {
        /* 0x00 */ public int Season;
    }
}
