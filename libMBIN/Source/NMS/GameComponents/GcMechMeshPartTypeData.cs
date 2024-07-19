using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB28D7131E52B2CD, NameHash = 0x6EE994F7)]
    public class GcMechMeshPartTypeData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 DescriptorGroupID;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x10> RequiredTechs;
    }
}
