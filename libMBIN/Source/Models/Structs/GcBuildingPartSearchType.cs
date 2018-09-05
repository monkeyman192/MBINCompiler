namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x20)]
    public class GcBuildingPartSearchType : NMSTemplate
    {
        public int BuildPartSearchType;
        public string[] BuildPartSearchTypeValues()
        {
            return new[] { "Base", "Freighter", "AllPlayerOwned", "OtherPlayerBase"};
        }
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public TkResourceFilterList BaseSearchFilters;
        public bool IncludeOnlyOverlappingBases;
        public bool IncludeGlobalBaseObjects;
        [NMS(Size = 0x6, Ignore = true)]
        public byte[] EndPadding;
    }
}
