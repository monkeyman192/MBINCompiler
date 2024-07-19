using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61607CC93A760247, NameHash = 0x5503D341)]
    public class GcBaseBuildingFamily : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x10 */ public List<NMSString0x10> ObjectIDs;
        // size: 0x2
        public enum FamilyTypeEnum : uint {
            Replacements,
            Extras,
        }
        [NMS(Index = 1)]
        /* 0x20 */ public FamilyTypeEnum FamilyType;
    }
}
