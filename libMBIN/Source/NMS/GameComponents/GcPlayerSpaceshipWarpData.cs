using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0F17792BB32DDF8, NameHash = 0x4F15030A)]
    public class GcPlayerSpaceshipWarpData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float EntryTime;
        [NMS(Index = 3)]
        /* 0x4 */ public float ExitTime;
        [NMS(Index = 2)]
        /* 0x8 */ public float TravelTunnelTime;
        [NMS(Index = 1)]
        /* 0xC */ public TkCurveType EntryTunnelCurve;
        [NMS(Index = 4)]
        /* 0xD */ public TkCurveType ExitTunnelCurve;
    }
}
