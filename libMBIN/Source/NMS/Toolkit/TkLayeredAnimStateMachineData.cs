using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x552EAFD3965C15B9, NameHash = 0x7D020710)]
    public class TkLayeredAnimStateMachineData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 1)]
        /* 0x20 */ public List<TkAnimStateMachineData> Layers;
        [NMS(Index = 2)]
        /* 0x30 */ public List<NMSTemplate> Parameters;
    }
}
