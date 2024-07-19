using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1272F8A08D8B463B, NameHash = 0x797901C9)]
    public class GcSentinelRobotComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSentinelTypes Type;
    }
}
