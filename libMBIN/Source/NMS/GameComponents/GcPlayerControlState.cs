using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1D1F181D9B2C18, NameHash = 0x9CBA2290362425C1)]
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
