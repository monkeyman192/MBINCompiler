using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2615DE9F43439438, NameHash = 0x9C4DEE4AEE9C44E)]
    public class GcCameraShakeTriggerData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Anim;
        /* 0x10 */ public int FrameStart;
        /* 0x14 */ public NMSString0x20 Shake;
    }
}
