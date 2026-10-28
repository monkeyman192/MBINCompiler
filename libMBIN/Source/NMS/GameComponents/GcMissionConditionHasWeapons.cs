namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3E144F7F60F0EAA, NameHash = 0x6A258504)]
    public class GcMissionConditionHasWeapons : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int CountForInstalledTests;
        // size: 0x7
        public enum WeaponTestEnum : uint {
            CombatPrimaryEquipped,
            CombatSecondaryEquipped,
            CombatPrimaryInstalled,
            CombatSecondaryInstalled,
            ExocraftCombatInstalled,
            ExocraftCombatActive,
            MultitoolPrimaryModeInstalled,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public WeaponTestEnum WeaponTest;
    }
}
