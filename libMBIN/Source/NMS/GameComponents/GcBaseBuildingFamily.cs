using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF43AC156DB4DF11, NameHash = 0x80538FB9394B74CA)]
    public class GcBaseBuildingFamily : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        public enum FamilyTypeEnum { Replacements, Extras }
        /* 0x10 */ public FamilyTypeEnum FamilyType;
        /* 0x18 */ public List<NMSString0x10> ObjectIDs;
    }
}
