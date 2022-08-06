using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8EC83D33BCEEDFC7, NameHash = 0x13FCF5FDFA2BFA4E)]
    public class GcAccessibleOverride_Text : NMSTemplate
    {
        // size: 0x1
        public enum AccessibleOverride_TextEnum { FontHeight }
        /* 0x0 */ public AccessibleOverride_TextEnum AccessibleOverride_Text;
        /* 0x4 */ public float FloatValue;
    }
}
