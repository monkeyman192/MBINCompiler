using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6FFCB8B2DC8653D, NameHash = 0x853AA38D)]
    public class GcTradingCategoryData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x18 */ public float ProductMultiplierChangePer100;
        [NMS(Index = 3)]
        /* 0x1C */ public float SubstanceMultiplierChangePer100;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x40 Name;
    }
}
