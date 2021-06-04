using libMBIN.NMS.Toolkit;
using System.Collections.Generic;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x70, GUID = 0x6D4181A7ABB245CB, NameHash = 0x9CBA2290362425C1)]
    public class GcPlayerControlState : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public bool StickToGround;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x11 */ public byte[] Padding11;
        /* 0x18 */ public GcPlayerControlInput OverrideInput;
        /* 0x50 */ public NMSString0x10 OverrideCamera;
        /* 0x60 */ public List<NMSTemplate> Data;
    }
}
