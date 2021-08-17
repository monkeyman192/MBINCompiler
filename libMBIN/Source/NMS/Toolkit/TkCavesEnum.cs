using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x12F71A6BF5C28E17, NameHash = 0x380AC5FAFC25FE69)]
    public class TkCavesEnum : NMSTemplate
    {
        // size: 0x1
        public enum CaveTypesEnum { Underground }
        /* 0x0 */ public CaveTypesEnum CaveTypes;
    }
}
