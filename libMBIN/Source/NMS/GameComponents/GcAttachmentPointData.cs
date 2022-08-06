using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF57E3DFFEC078B9, NameHash = 0x5E18E1A975BA4573)]
    public class GcAttachmentPointData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public int SimP;
        /* 0x14 */ public float AttractionStrength;
        /* 0x18 */ public float AttractionStartDistance;
    }
}
