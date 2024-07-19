using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF972F2C454624D8C, NameHash = 0xF59D530C)]
    public class GcGalaxyWaypoint : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A EventId;
        [NMS(Index = 0)]
        /* 0x20 */ public GcGalacticAddressData Address;
        [NMS(Index = 1)]
        /* 0x34 */ public GcGalaxyWaypointTypes Type;
    }
}
