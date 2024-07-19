using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD4F4D1E7D19DB999, NameHash = 0x9E0F95A6)]
    public class GcNPCPropTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xF, EnumType = typeof(GcNPCPropType.NPCPropEnum))]
        /* 0x0 */ public GcNPCPropInfo[] Props;
    }
}
