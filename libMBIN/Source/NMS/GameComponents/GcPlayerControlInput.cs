using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AC5F747505AAF2A, NameHash = 0xD2873CCA9A0EDD77)]
    public class GcPlayerControlInput : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Inputs;
        /* 0x10 */ public List<GcInputActions> InterceptInputBlackList;
        /* 0x20 */ public List<GcInputActions> InterceptInputWhitelist;
        /* 0x30 */ public bool InterceptAllInputs;
    }
}
