using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2CB6642F555160E8, NameHash = 0xD2873CCA9A0EDD77)]
    public class GcPlayerControlInput : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<NMSTemplate> Inputs;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcInputActions> InterceptInputBlackList;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcInputActions> InterceptInputWhitelist;
        [NMS(Index = 0)]
        /* 0x30 */ public bool InterceptAllInputs;
    }
}
