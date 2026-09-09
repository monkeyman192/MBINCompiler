using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9991B7D4393CCB0D, NameHash = 0xC72617F3)]
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
