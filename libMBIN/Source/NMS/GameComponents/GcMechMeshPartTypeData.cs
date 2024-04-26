using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x845B85A6E3BCC156, NameHash = 0x29EEF8B053EA8F56)]
    public class GcMechMeshPartTypeData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> RequiredTechs;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20 LocatorNodeName;
    }
}
