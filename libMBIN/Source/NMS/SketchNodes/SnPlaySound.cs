using System;
using System.Collections.Generic;
using System.Text;

using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.SketchNodes
{
    [NMS(Size = 0x8)]
    public class SnPlaySound : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents Event;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4 */ public byte[] EndPadding;
        // IONode: Out: 0: Src, 1: Sound
    }
}
