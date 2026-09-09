using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF2A4C482970A1B9, NameHash = 0xB724BB00)]
    public class GcMissionConditionSolarSystemMapMarked : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 SpacePoiID;
        [NMS(Index = 2)]
        /* 0x10 */ public GcSpacePoiType SpacePoiType;
        [NMS(Index = 0)]
        /* 0x14 */ public bool AnyMarker;
    }
}
