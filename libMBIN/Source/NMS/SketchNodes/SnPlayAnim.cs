using System;
using System.Collections.Generic;
using System.Text;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x18)]
    public class SnPlayAnim : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Anim;
        /* 0x10 */ public bool Synchronised;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x11 */ public byte[] EndPadding;
        // Note: Some entities look to have two floats at the end, but their type is also 0... And there is no reference to this in the exe... :/
    }
}
