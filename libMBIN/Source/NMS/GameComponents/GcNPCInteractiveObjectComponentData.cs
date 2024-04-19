using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3E2F725E0397C09, NameHash = 0x6EB308F16DDC755C)]
    public class GcNPCInteractiveObjectComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcNPCInteractiveObjectState> States;
        /* 0x10 */ public float DurationMax;
        /* 0x14 */ public float DurationMin;
        /* 0x18 */ public GcNPCInteractiveObjectType InteractiveObjectType;
        /* 0x1C */ public int MaxCapacity;
    }
}
