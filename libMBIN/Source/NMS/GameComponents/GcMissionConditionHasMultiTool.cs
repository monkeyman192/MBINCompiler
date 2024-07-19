using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D0DA0379EE73D84, NameHash = 0x8FA40B3A)]
    public class GcMissionConditionHasMultiTool : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcInventoryClass InventoryClass;
        [NMS(Index = 5)]
        /* 0x4 */ public GcWeaponClasses WeaponClass;
        [NMS(Index = 2)]
        /* 0x8 */ public bool BetterClassMatches;
        [NMS(Index = 1)]
        /* 0x9 */ public bool CheckAllTools;
        [NMS(Index = 4)]
        /* 0xA */ public bool MustMatchWeaponClass;
        [NMS(Index = 3)]
        /* 0xB */ public bool TakeValueFromSeasonData;
    }
}
