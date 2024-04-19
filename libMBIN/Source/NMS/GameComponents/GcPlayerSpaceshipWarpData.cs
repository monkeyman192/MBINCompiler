using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x31AE5D12112FF00, NameHash = 0x69AE13F58EC1B23A)]
    public class GcPlayerSpaceshipWarpData : NMSTemplate
    {
        /* 0x0 */ public float EntryTime;
        /* 0x4 */ public float ExitTime;
        /* 0x8 */ public float TravelTunnelTime;
        /* 0xC */ public TkCurveType EntryTunnelCurve;
        /* 0xD */ public TkCurveType ExitTunnelCurve;
    }
}
