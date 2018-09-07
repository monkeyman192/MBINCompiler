using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcBuildingPartSearchType : NMSTemplate
    {
		public enum BuildPartSearchTypeEnum { Base, Freighter, AllPlayerOwned, OtherPlayerBase }
		public BuildPartSearchTypeEnum BuildPartSearchType;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<GcPersistentBaseTypes> BaseSearchFilters;
        public bool IncludeOnlyOverlappingBases;
        public bool IncludeGlobalBaseObjects;
        [NMS(Size = 0x6, Ignore = true)]
        public byte[] EndPadding;
    }
}
