using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x244ED03FC323784A, NameHash = 0x0BCDA670B36E2534)]
    public class GcExperienceDebugTriggerInput : NMSTemplate
    {
        // size: 0xD
        public enum KeyPressEnum { _1, _2, _3, _4, _5, _6, _7, _8, _9, PadUp, PadDown, PadLeft, PadRight };
        /* 0x0 */ public KeyPressEnum KeyPress;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4 */ public byte[] Padding4;
        /* 0x8 */ public List<GcExperienceDebugTriggerAction> Actions;
    }
}
