using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4B899C8C14567AE, NameHash = 0xE90BC34FB3DEA4D7)]
    public class GcCostProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int Amount;
        /* 0x14 */ public GcDefaultMissionProductEnum Default;
        /* 0x18 */ public bool UseDefaultAmount;
    }
}
