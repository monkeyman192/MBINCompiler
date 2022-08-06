using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC7AFEEE03C00641, NameHash = 0xA8EFE022A74D3291)]
    public class GcSentinelSpawnSequence : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Waves;
    }
}
