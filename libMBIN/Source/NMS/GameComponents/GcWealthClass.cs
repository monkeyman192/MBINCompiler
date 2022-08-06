using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB87612EA8CD6DBDE, NameHash = 0xC0B928F5E2599F60)]
    public class GcWealthClass : NMSTemplate
    {
        // size: 0x4
        public enum WealthClassEnum { Poor, Average, Wealthy, Pirate }
        /* 0x0 */ public WealthClassEnum WealthClass;
    }
}
