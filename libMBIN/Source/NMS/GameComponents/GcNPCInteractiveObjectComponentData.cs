using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E252E7064A95323, NameHash = 0xE9F0317D)]
    public class GcNPCInteractiveObjectComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public List<GcNPCInteractiveObjectState> States;
        [NMS(Index = 3)]
        /* 0x10 */ public float DurationMax;
        [NMS(Index = 2)]
        /* 0x14 */ public float DurationMin;
        [NMS(Index = 0)]
        /* 0x18 */ public GcNPCInteractiveObjectType InteractiveObjectType;
        [NMS(Index = 1)]
        /* 0x1C */ public int MaxCapacity;
    }
}
