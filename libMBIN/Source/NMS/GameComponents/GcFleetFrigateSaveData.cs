using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x435E58CE581A8ED5, NameHash = 0xE6F863FE26F77270)]
    public class GcFleetFrigateSaveData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcSeed ForcedTraitsSeed;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSeed HomeSystemSeed;
        [NMS(Index = 0)]
        /* 0x20 */ public GcSeed ResourceSeed;
        [NMS(Index = 13)]
        /* 0x30 */ public List<int> Stats;
        [NMS(Index = 12)]
        /* 0x40 */ public List<NMSString0x10> TraitIDs;
        [NMS(Index = 3)]
        /* 0x50 */ public ulong TimeOfLastIncomeCollection;
        [NMS(Index = 15)]
        /* 0x58 */ public int DamageTaken;
        [NMS(Index = 5)]
        /* 0x5C */ public GcFrigateClass FrigateClass;
        [NMS(Index = 7)]
        /* 0x60 */ public GcInventoryClass InventoryClass;
        [NMS(Index = 11)]
        /* 0x64 */ public int NumberOfTimesDamaged;
        [NMS(Index = 6)]
        /* 0x68 */ public GcAlienRace Race;
        [NMS(Index = 14)]
        /* 0x6C */ public int RepairsMade;
        [NMS(Index = 8)]
        /* 0x70 */ public int TotalNumberOfExpeditions;
        [NMS(Index = 10)]
        /* 0x74 */ public int TotalNumberOfFailedEvents;
        [NMS(Index = 9)]
        /* 0x78 */ public int TotalNumberOfSuccessfulEvents;
        [NMS(Index = 4)]
        /* 0x7C */ public NMSString0x100 CustomName;
    }
}
