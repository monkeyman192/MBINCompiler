using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x3BC2543792E9B519, NameHash = 0x16AC643981D10CC9, Broken = true)]
    public class GcSmokeBotReport : NMSTemplate
    {
        /* 0x00 */ public ulong StartingUA;
        /* 0x08 */ public List<GcSmokeBotSystemReport> Systems;
    }
}
