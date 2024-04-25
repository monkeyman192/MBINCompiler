using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED77BBD7595FB24A, NameHash = 0xAEBE0762190D9B2)]
    public class GcBuildingPartSearchType : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcPersistentBaseTypes> BaseSearchFilters;
        // size: 0x4
        public enum BuildPartSearchTypeEnum : uint {
            Base,
            Freighter,
            AllPlayerOwned,
            OtherPlayerBase,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public BuildPartSearchTypeEnum BuildPartSearchType;
        [NMS(Index = 3)]
        /* 0x14 */ public bool IncludeGlobalBaseObjects;
        [NMS(Index = 2)]
        /* 0x15 */ public bool IncludeOnlyOverlappingBases;
    }
}
