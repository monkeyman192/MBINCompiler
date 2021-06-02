using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x168, GUID = 0x1244A53919988284, NameHash = 0xE6F863FE26F77270)]
    public class GcFleetFrigateSaveData : NMSTemplate
    {
        /* 0x000 */ public GcSeed ResourceSeed;
        /* 0x010 */ public GcSeed HomeSystemSeed;
        /* 0x020 */ public ulong TimeOfLastIncomeCollection;
        /* 0x028 */ public NMSString0x100 CustomName;
        /* 0x128 */ public GcFrigateClass FrigateClass;
        /* 0x12C */ public GcAlienRace Race;
        /* 0x130 */ public int TotalNumberOfExpeditions;
        /* 0x134 */ public int TotalNumberOfSuccessfulEvents;
        /* 0x138 */ public int TotalNumberOfFailedEvents;
        /* 0x13C */ public int NumberOfTimesDamaged;
        /* 0x140 */ public List<NMSString0x10> TraitIDs;
        /* 0x150 */ public List<int> Stats;
        /* 0x160 */ public int RepairsMade;
        /* 0x164 */ public int DamageTaken;
    }
}
