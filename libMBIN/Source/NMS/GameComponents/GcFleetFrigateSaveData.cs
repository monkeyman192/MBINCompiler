using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C198F8780E487C8, NameHash = 0xE6F863FE26F77270)]
    public class GcFleetFrigateSaveData : NMSTemplate
    {
        /* 0x000 */ public GcSeed ResourceSeed;
        /* 0x010 */ public GcSeed HomeSystemSeed;
        /* 0x020 */ public GcSeed ForcedTraitsSeed;
        /* 0x030 */ public ulong TimeOfLastIncomeCollection;
        /* 0x038 */ public NMSString0x100 CustomName;
        /* 0x138 */ public GcFrigateClass FrigateClass;
        /* 0x13C */ public GcAlienRace Race;
        /* 0x140 */ public GcInventoryClass InventoryClass;
        /* 0x144 */ public int TotalNumberOfExpeditions;
        /* 0x148 */ public int TotalNumberOfSuccessfulEvents;
        /* 0x14C */ public int TotalNumberOfFailedEvents;
        /* 0x150 */ public int NumberOfTimesDamaged;
        /* 0x158 */ public List<NMSString0x10> TraitIDs;
        /* 0x168 */ public List<int> Stats;
        /* 0x178 */ public int RepairsMade;
        /* 0x17C */ public int DamageTaken;
    }
}
