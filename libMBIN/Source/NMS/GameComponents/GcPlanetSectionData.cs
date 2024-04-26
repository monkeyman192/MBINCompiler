namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BFC6055460243D3, NameHash = 0x408CCAADC93DEEFE)]
    public class GcPlanetSectionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public ulong DiscovererUID;
        [NMS(Index = 1, Size = 0x2)]
        /* 0x8 */ public byte[] DiscovererPlatform;
        [NMS(Index = 2)]
        /* 0xA */ public bool DiscoveredState;
    }
}
