using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB16A3743D548B65, NameHash = 0x326181BC)]
    public class GcMissionConditionIsSpacePoiInCurrentSystem : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 SpacePoiID;
        [NMS(Index = 4)]
        /* 0x10 */ public GcSpacePoiDiscoveryLevel MaxDiscoveryLevel;
        [NMS(Index = 3)]
        /* 0x14 */ public GcSpacePoiDiscoveryLevel MinDiscoveryLevel;
        [NMS(Index = 2)]
        /* 0x18 */ public GcSpacePoiType SpacePoiType;
        [NMS(Index = 1)]
        /* 0x1C */ public bool SearchByType;
    }
}
