using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB57AF65A4F72A70C, NameHash = 0xA95CE4EF897F62B2)]
    public class GcExpeditionEventSaveData : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public ulong UA;
        /* 0x18 */ public List<int> AffectedFrigateIndices;
        /* 0x28 */ public List<int> RepairingFrigateIndices;
        /* 0x38 */ public List<int> AffectedFrigateResponses;
        /* 0x48 */ public NMSString0x20A EventID;
        /* 0x68 */ public NMSString0x20A InterventionEventID;
        /* 0x88 */ public NMSString0x40 OverriddenDescription;
        /* 0xC8 */ public bool WhaleEvent;
        /* 0xD0 */ public NMSString0x10 OverriddenReward;
        /* 0xE0 */ public bool Success;
        /* 0xE1 */ public bool IsInterventionEvent;
        /* 0xE2 */ public bool AvoidedIntervention;
    }
}
