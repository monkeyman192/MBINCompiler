using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4E6338F9F235C3D, NameHash = 0xC04EFF3E2A378ED7)]
    public class GcRewardDisplayTechWindow : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TechID;
        /* 0x10 */ public bool Damaged;
        /* 0x11 */ public bool NeedsInstall;
        /* 0x12 */ public bool FullBox;
    }
}
