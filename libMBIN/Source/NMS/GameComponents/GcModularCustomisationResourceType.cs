namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x345D66AE9CDDBF5C, NameHash = 0x89CBAB6)]
    public class GcModularCustomisationResourceType : NMSTemplate
    {
        // size: 0x6
        public enum ModularCustomisationResourceTypeEnum : uint {
            MultiToolStaff,
            Fighter,
            Dropship,
            Scientific,
            Shuttle,
            Sail,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ModularCustomisationResourceTypeEnum ModularCustomisationResourceType;
    }
}
