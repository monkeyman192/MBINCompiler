using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x14, GUID = 0x3B4F33D91D98F4AF, NameHash = 0xD22200F6DB5FF136)]
    public class CgExpeditionCategoryStrength : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcExpeditionCategory.ExpeditionCategoryEnum))]
        /* 0x0 */ public int[] OccurranceChance;
    }
}
