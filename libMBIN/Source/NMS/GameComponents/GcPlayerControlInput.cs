using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x0D4EB754C968F00C, NameHash = 0xD2873CCA9A0EDD77)]
    public class GcPlayerControlInput : NMSTemplate
    {
        /* 0x00 */ public bool InterceptAllInputs;
        /* 0x08 */ public List<GcInputActions> InterceptInputWhitelist;
        /* 0x18 */ public List<GcInputActions> InterceptInputBlackList;
        /* 0x28 */ public List<NMSTemplate> Inputs;
    }
}
