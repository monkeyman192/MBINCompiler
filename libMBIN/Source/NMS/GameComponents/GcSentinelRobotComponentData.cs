using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x748FBAE12369C6E0, NameHash = 0xC3E852EF937E74B5)]
    public class GcSentinelRobotComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public GcSentinelTypes Type;
    }
}
