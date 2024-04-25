using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF887B4D5ED768DE2, NameHash = 0xA66A9F625C0BD43C)]
    public class GcExpeditionCategoryStrength : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        /* 0x0 */ public int[] OccurranceChance;
    }
}
