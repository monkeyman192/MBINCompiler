using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x940A8EF73E23EBCC, NameHash = 0xC72617F3)]
    public class GcSettlementColourUpgradeTable : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x3)]
        /* 0x00 */ public GcSettlementColourUpgradeData[] UpgradeLevels;
        [NMS(Index = 0)]
        /* 0x60 */ public NMSString0x10 Name;
        [NMS(Index = 1)]
        /* 0x70 */ public GcBaseBuildingPartStyle Style;
    }
}
