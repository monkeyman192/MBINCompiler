using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E264C5ADCC6B1F6, NameHash = 0xC6353828)]
    public class GcCostDiscovery : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A CostString;
        [NMS(Index = 1)]
        /* 0x20 */ public GcDiscoveryType DiscoveryType;
        [NMS(Index = 2)]
        /* 0x24 */ public int Index;
    }
}
