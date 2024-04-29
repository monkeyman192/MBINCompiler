using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC0DB13DD020EEEF, NameHash = 0x22BD6A8E5AD4C4CB)]
    public class GcNPCPropTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xF, EnumType = typeof(GcNPCPropType.NPCPropEnum))]
        /* 0x0 */ public GcNPCPropInfo[] Props;
    }
}
