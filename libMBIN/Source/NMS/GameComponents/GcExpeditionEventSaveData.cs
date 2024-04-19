using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6B3E5D5803B3967, NameHash = 0xA95CE4EF897F62B2)]
    public class GcExpeditionEventSaveData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A EventID;
        /* 0x20 */ public NMSString0x20A InterventionEventID;
        /* 0x40 */ public NMSString0x20A OverriddenRewardDescription;
        /* 0x60 */ public List<int> AffectedFrigateIndices;
        /* 0x70 */ public List<int> AffectedFrigateResponses;
        /* 0x80 */ public NMSString0x10 OverriddenReward;
        /* 0x90 */ public List<int> RepairingFrigateIndices;
        /* 0xA0 */ public GcSeed Seed;
        /* 0xB0 */ public ulong UA;
        /* 0xB8 */ public NMSString0x40 OverriddenDescription;
        /* 0xF8 */ public bool AvoidedIntervention;
        /* 0xF9 */ public bool IsInterventionEvent;
        /* 0xFA */ public bool Success;
        /* 0xFB */ public bool WhaleEvent;
    }
}
