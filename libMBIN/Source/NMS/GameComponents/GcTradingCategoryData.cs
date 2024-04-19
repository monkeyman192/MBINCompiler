using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8CB3BE00363FBA01, NameHash = 0x39D1580ABEEE58C3)]
    public class GcTradingCategoryData : NMSTemplate
    {
        /* 0x00 */ public TkTextureResource Icon;
        /* 0x84 */ public float ProductMultiplierChangePer100;
        /* 0x88 */ public float SubstanceMultiplierChangePer100;
        /* 0x8C */ public NMSString0x40 Name;
    }
}
