namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x909F438E4B6E8D9F, NameHash = 0xD14651666CB8A6EB)]
    public class GcDiscoveryHelperTimings : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float DiscoverPlanetMessageTime;
        [NMS(Index = 1)]
        /* 0x4 */ public float DiscoverPlanetMessageWait;
        [NMS(Index = 0)]
        /* 0x8 */ public float DiscoverPlanetTotalTime;
    }
}
