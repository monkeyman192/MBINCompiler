using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE2FDB3256F6FF4CD, NameHash = 0xC728D4342BAC4AC8)]
    public class TkPlatformButtonPair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PlatformId;
        /* 0x10 */ public NMSString0x10 ButtonId;
        /* 0x20 */ public Vector2f Size;
    }
}
