using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6B3E5D5803B3967, NameHash = 0xA95CE4EF897F62B2)]
    public class GcExpeditionEventSaveData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A EventID;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x20A InterventionEventID;
        [NMS(Index = 10)]
        /* 0x40 */ public NMSString0x20A OverriddenRewardDescription;
        [NMS(Index = 2)]
        /* 0x60 */ public List<int> AffectedFrigateIndices;
        [NMS(Index = 4)]
        /* 0x70 */ public List<int> AffectedFrigateResponses;
        [NMS(Index = 9)]
        /* 0x80 */ public NMSString0x10 OverriddenReward;
        [NMS(Index = 3)]
        /* 0x90 */ public List<int> RepairingFrigateIndices;
        [NMS(Index = 0)]
        /* 0xA0 */ public GcSeed Seed;
        [NMS(Index = 1)]
        /* 0xB0 */ public ulong UA;
        [NMS(Index = 7)]
        /* 0xB8 */ public NMSString0x40 OverriddenDescription;
        [NMS(Index = 13)]
        /* 0xF8 */ public bool AvoidedIntervention;
        [NMS(Index = 12)]
        /* 0xF9 */ public bool IsInterventionEvent;
        [NMS(Index = 11)]
        /* 0xFA */ public bool Success;
        [NMS(Index = 8)]
        /* 0xFB */ public bool WhaleEvent;
    }
}
