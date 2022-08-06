using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84A91A7DBE52F7A0, NameHash = 0x132E24BDAE218C83)]
    public class GcLegacyItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x10 ConvertID;
        /* 0x20 */ public float ConvertRatio;
        /* 0x24 */ public bool AddnewRecipe;
        /* 0x25 */ public bool RemoveOldRecipe;
    }
}
