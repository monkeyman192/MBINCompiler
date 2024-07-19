using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x303AA49E9AB08F73, NameHash = 0xF4502DD5)]
    public class GcCustomisationGroups : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCustomisationGroup> CustomisationGroups;
    }
}
