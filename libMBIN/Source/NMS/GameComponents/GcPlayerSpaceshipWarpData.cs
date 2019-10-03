using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xFC0B28004AD759EC, NameHash = 0x69AE13F58EC1B23A)]
    public class GcPlayerSpaceshipWarpData : NMSTemplate
    {
        /* 0x000 */ public float EntryTime;
        /* 0x004 */ public TkCurveType EntryTunnelCurve;
        /* 0x008 */ public float EntryTunnelDistance;
        /* 0x00C */ public float EntryWorldlDistance;
        /* 0x010 */ public float TravelTunnelTime;
        /* 0x014 */ public float TravelTunnelDriftDist;
		/* 0x018 */ public float TravelDriftRate;
		/* 0x01C */ public float ExitTime;
		/* 0x020 */ public float ExitHoldAlphaTime;
		/* 0x024 */ public TkCurveType ExitTunnelCurve;
		/* 0x028 */ public float ExitTunnelDistance;
		/* 0x02C */ public float ExitWorldDistance;
    }
}
