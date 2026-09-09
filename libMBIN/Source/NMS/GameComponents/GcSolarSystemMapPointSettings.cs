using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F41818AAF77AF1C, NameHash = 0x9C0A164C)]
    public class GcSolarSystemMapPointSettings : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkTextureResource DiscoveredIcon;
        [NMS(Index = 0)]
        /* 0x18 */ public TkTextureResource UndiscoveredIcon;
    }
}
