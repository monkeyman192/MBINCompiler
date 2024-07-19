using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BE1903FE8AB9697, NameHash = 0xFFD058AB)]
    public class GcPlayerControlState : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcPlayerControlInput OverrideInput;
        [NMS(Index = 4)]
        /* 0x38 */ public List<NMSTemplate> Data;
        [NMS(Index = 0)]
        /* 0x48 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x58 */ public NMSString0x10 OverrideCamera;
        [NMS(Index = 1)]
        /* 0x68 */ public bool StickToGround;
    }
}
