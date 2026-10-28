using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD486167B61C17A2B, NameHash = 0x4550DAE9)]
    public class GcRecyclableComponentData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcRecyclableType.RecyclableTypeEnum))]
        /* 0x0 */ public GcRecyclableReward[] RecyclerReward;
    }
}
