namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50A178234C7BFD1C, NameHash = 0xE3A40329)]
    public class GcLinkNetworkTypes : NMSTemplate
    {
        // size: 0x6
        public enum LinkNetworkTypeEnum : uint {
            Power,
            Resources,
            Fuel,
            Portals,
            PlantGrowth,
            ByteBeat,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public LinkNetworkTypeEnum LinkNetworkType;
    }
}
