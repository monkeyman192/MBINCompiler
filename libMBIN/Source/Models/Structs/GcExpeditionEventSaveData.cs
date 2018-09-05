using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x90)]
    public class GcExpeditionEventSaveData : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public ulong UA;
        /* 0x18 */ public List<int> AffectedFrigateIndices;
        /* 0x28 */ public List<int> RepairingFrigateIndices;
        /* 0x38 */ public List<int> AffectedFrigateResponses;
        [NMS(Size = 0x20)]
        /* 0x48 */ public string EventID;
        [NMS(Size = 0x20)]
        /* 0x68 */ public string InterventionEventID;
        /* 0x88 */ public bool Success;
        /* 0x89 */ public bool IsInterventionEvent;
        /* 0x8A */ public bool AvoidedIntervention;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x8B */ public byte[] EndPadding;
    }
}
