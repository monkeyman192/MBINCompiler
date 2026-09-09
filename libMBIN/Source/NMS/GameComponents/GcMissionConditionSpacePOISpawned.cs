using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED144CF5580B997F, NameHash = 0xA2BCAE81)]
    public class GcMissionConditionSpacePOISpawned : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 SpacePoiID;
        [NMS(Index = 2)]
        /* 0x10 */ public GcSpacePoiType SpacePoiType;
        [NMS(Index = 0)]
        /* 0x14 */ public bool AnySpacePoi;
        [NMS(Index = 3)]
        /* 0x15 */ public bool RequireFullySpawned;
        [NMS(Index = 4)]
        /* 0x16 */ public bool RequireNotCompleted;
    }
}
