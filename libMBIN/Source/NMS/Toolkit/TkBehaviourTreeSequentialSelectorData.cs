using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD65DA5CDBAC707E0, NameHash = 0x22976703)]
    public class TkBehaviourTreeSequentialSelectorData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<NMSTemplate> Children;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Name;
        [NMS(Index = 2)]
        /* 0x20 */ public bool FailWhenAnyChildFails;
        [NMS(Index = 1)]
        /* 0x21 */ public bool Looping;
    }
}
