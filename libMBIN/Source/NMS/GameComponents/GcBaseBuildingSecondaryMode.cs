namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6596E10498EDD99, NameHash = 0xA18094D9)]
    public class GcBaseBuildingSecondaryMode : NMSTemplate
    {
        // size: 0x2
        public enum BaseBuildingSecondaryModeEnum : uint {
            ShipStructural,
            StationExterior,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseBuildingSecondaryModeEnum BaseBuildingSecondaryMode;
    }
}
