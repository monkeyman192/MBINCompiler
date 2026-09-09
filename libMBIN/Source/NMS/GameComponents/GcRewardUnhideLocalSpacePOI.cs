using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA292356A2C4E675F, NameHash = 0x5B9D4EDD)]
    public class GcRewardUnhideLocalSpacePOI : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A SearchOSD;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 SpacePoiID;
        [NMS(Index = 2)]
        /* 0x30 */ public GcSpacePoiDiscoveryLevel MaxDiscoveryLevel;
        [NMS(Index = 1)]
        /* 0x34 */ public GcSpacePoiType SpacePoiType;
        [NMS(Index = 3)]
        /* 0x38 */ public GcSpacePoiDiscoveryLevel UpgradeToDiscoveryLevel;
        [NMS(Index = 4)]
        /* 0x3C */ public bool SetMapMarker;
    }
}
