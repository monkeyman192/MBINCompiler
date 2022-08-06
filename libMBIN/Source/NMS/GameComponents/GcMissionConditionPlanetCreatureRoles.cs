using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69389DF86BF33D76, NameHash = 0x10FE4DB9ECB98372)]
    public class GcMissionConditionPlanetCreatureRoles : NMSTemplate
    {
        /* 0x0 */ public int NumRoles;
        /* 0x4 */ public TkEqualityEnum Test;
        /* 0x8 */ public bool TakeNumFromSeasonData;
    }
}
