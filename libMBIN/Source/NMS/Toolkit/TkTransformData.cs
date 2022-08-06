using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x183EF44FE92F3F19, NameHash = 0x984D549B93F94207)]
    public class TkTransformData : NMSTemplate
    {
        /* 0x00 */ public float TransX;
        /* 0x04 */ public float TransY;
        /* 0x08 */ public float TransZ;
        /* 0x0C */ public float RotX;
        /* 0x10 */ public float RotY;
        /* 0x14 */ public float RotZ;
        /* 0x18 */ public float ScaleX;
        /* 0x1C */ public float ScaleY;
        /* 0x20 */ public float ScaleZ;
    }
}
