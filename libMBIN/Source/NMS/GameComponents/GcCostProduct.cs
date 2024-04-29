using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x934BD969222FFDA3, NameHash = 0xE90BC34FB3DEA4D7)]
    public class GcCostProduct : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x14 */ public GcDefaultMissionProductEnum Default;
        [NMS(Index = 3)]
        /* 0x18 */ public bool UseDefaultAmount;
    }
}
