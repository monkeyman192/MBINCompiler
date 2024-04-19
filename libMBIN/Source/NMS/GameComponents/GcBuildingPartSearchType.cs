using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED77BBD7595FB24A, NameHash = 0xAEBE0762190D9B2)]
    public class GcBuildingPartSearchType : NMSTemplate
    {
        /* 0x00 */ public List<GcPersistentBaseTypes> BaseSearchFilters;
        // size: 0x4
        public enum BuildPartSearchTypeEnum : uint {
            Base,
            Freighter,
            AllPlayerOwned,
            OtherPlayerBase,
        }
        /* 0x10 */ public BuildPartSearchTypeEnum BuildPartSearchType;
        /* 0x14 */ public bool IncludeGlobalBaseObjects;
        /* 0x15 */ public bool IncludeOnlyOverlappingBases;
    }
}
