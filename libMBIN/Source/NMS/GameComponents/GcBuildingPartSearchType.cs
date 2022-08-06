using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC69835B2E1D8BB94, NameHash = 0xAEBE0762190D9B2)]
    public class GcBuildingPartSearchType : NMSTemplate
    {
		public enum BuildPartSearchTypeEnum { Base, Freighter, AllPlayerOwned, OtherPlayerBase }
		public BuildPartSearchTypeEnum BuildPartSearchType;
        public List<GcPersistentBaseTypes> BaseSearchFilters;
        public bool IncludeOnlyOverlappingBases;
        public bool IncludeGlobalBaseObjects;
    }
}
