using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC40E159555857D5, NameHash = 0x62C174D7)]
    public class GcMissionConditionIsInsideSpacePoi : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 SpacePoiID;
        [NMS(Index = 4)]
        /* 0x10 */ public GcSpacePoiDiscoveryLevel DiscoveryLevel;
        [NMS(Index = 2)]
        /* 0x14 */ public GcSpacePoiType SpacePoiType;
        [NMS(Index = 0)]
        /* 0x18 */ public bool AnySpacePoi;
        [NMS(Index = 5)]
        /* 0x19 */ public bool CanSetIcon;
        [NMS(Index = 3)]
        /* 0x1A */ public bool RequiresDiscoveryLevel;
    }
}
