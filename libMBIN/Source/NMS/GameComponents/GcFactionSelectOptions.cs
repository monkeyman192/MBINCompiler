using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x418CE861C6D3D21C, NameHash = 0x49D48E5A22491956)]
    public class GcFactionSelectOptions : NMSTemplate
    {
        // size: 0x3
        public enum FactionOptionEnum { DataDefined, CurrentMission, CurrentSystem }
        /* 0x0 */ public FactionOptionEnum FactionOption;
        /* 0x4 */ public GcMissionFaction Faction;
    }
}
