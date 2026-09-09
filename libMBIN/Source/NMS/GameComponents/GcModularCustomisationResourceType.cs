namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x397EA613FEC52AF9, NameHash = 0x89CBAB6)]
    public class GcModularCustomisationResourceType : NMSTemplate
    {
        // size: 0xC
        public enum ModularCustomisationResourceTypeEnum : uint {
            MultiToolStaff,
            Fighter,
            Dropship,
            Scientific,
            Shuttle,
            Sail,
            ExhibitTRex,
            ExhibitWorm,
            ExhibitGrunt,
            ExhibitQuadruped,
            ExhibitBird,
            StationExterior,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ModularCustomisationResourceTypeEnum ModularCustomisationResourceType;
    }
}
