using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB97BC599BFC776D7, NameHash = 0xD38FE493F39C7CF8)]
    public class GcSentinelnWaveGroup : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Waves;
        /* 0x10 */ public List<NMSString0x10> ExtremeWaves;
    }
}
