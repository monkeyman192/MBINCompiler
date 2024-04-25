namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50A178234C7BFD1C, NameHash = 0xA2D103E3C1ECFE30)]
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
