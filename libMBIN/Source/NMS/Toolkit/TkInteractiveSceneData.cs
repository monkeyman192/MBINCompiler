using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3BF2E8D1B031BC04, NameHash = 0x89317714328CB341)]
    public class TkInteractiveSceneData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkInteractiveControlData> Controls;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20 Id;
    }
}
