using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x220F52EAD83FD208, NameHash = 0x562052A8272CC4A3)]
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
