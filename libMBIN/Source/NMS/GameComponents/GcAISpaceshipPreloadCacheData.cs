using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2CFD6BFBB7EED356, NameHash = 0x74723646531009E2)]
    public class GcAISpaceshipPreloadCacheData : NMSTemplate
    {
        /* 0x00 */ public GcRealityCommonFactions Faction;
        /* 0x04 */ public GcAISpaceshipRoles ShipRole;
        /* 0x08 */ public GcSpaceshipClasses ShipClass;
        /* 0x0C */ public GcFrigateClass FrigateClass;
        /* 0x10 */ public GcSeed Seed;
    }
}
