using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A0A16C07A31883, NameHash = 0xF65D2CFF75A05B47)]
    public class GcMissionConditionHasMultiTool : NMSTemplate
    {
        /* 0x0 */ public GcInventoryClass InventoryClass;
        /* 0x4 */ public GcWeaponClasses WeaponClass;
        /* 0x8 */ public bool BetterClassMatches;
        /* 0x9 */ public bool CheckAllTools;
        /* 0xA */ public bool MustMatchWeaponClass;
        /* 0xB */ public bool TakeValueFromSeasonData;
    }
}
