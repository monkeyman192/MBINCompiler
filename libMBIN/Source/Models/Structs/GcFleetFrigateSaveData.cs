using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x168)]
    public class GcFleetFrigateSaveData : NMSTemplate
    {
        /* 0x000 */ public GcSeed ResourceSeed;
        /* 0x010 */ public GcSeed HomeSystemSeed;
        /* 0x020 */ public ulong TimeOfLastIncomeCollection;
        [NMS(Size = 0x100)]
        /* 0x028 */ public string CustomName;
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
