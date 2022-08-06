using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEDA17FCFCFA9F9A, NameHash = 0xC0220D51AA0E426)]
    public class GcCreatureBehaviourTreeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<NMSTemplate> Nodes;
    }
}
