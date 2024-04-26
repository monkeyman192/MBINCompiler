using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8CB3BE00363FBA01, NameHash = 0x39D1580ABEEE58C3)]
    public class GcTradingCategoryData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x84 */ public float ProductMultiplierChangePer100;
        [NMS(Index = 3)]
        /* 0x88 */ public float SubstanceMultiplierChangePer100;
        [NMS(Index = 0)]
        /* 0x8C */ public NMSString0x40 Name;
    }
}
