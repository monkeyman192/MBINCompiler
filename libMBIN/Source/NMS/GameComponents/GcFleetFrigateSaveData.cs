using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C10D4AF2D36D4A7, NameHash = 0xE6F863FE26F77270)]
    public class GcFleetFrigateSaveData : NMSTemplate
    {
        /* 0x00 */ public GcSeed ForcedTraitsSeed;
        /* 0x10 */ public GcSeed HomeSystemSeed;
        /* 0x20 */ public GcSeed ResourceSeed;
        /* 0x30 */ public List<int> Stats;
        /* 0x40 */ public List<NMSString0x10> TraitIDs;
        /* 0x50 */ public ulong TimeOfLastIncomeCollection;
        /* 0x58 */ public int DamageTaken;
        /* 0x5C */ public GcFrigateClass FrigateClass;
        /* 0x60 */ public GcInventoryClass InventoryClass;
        /* 0x64 */ public int NumberOfTimesDamaged;
        /* 0x68 */ public GcAlienRace Race;
        /* 0x6C */ public int RepairsMade;
        /* 0x70 */ public int TotalNumberOfExpeditions;
        /* 0x74 */ public int TotalNumberOfFailedEvents;
        /* 0x78 */ public int TotalNumberOfSuccessfulEvents;
        /* 0x7C */ public NMSString0x100 CustomName;
    }
}
