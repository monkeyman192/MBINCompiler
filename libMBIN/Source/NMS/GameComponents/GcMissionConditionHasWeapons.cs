namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68B82718A3FBC7F8, NameHash = 0x6A258504)]
    public class GcMissionConditionHasWeapons : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int CountForInstalledTests;
        // size: 0x6
        public enum WeaponTestEnum : uint {
            CombatPrimaryEquipped,
            CombatSecondaryEquipped,
            CombatPrimaryInstalled,
            CombatSecondaryInstalled,
            ExocraftCombatInstalled,
            ExocraftCombatActive,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public WeaponTestEnum WeaponTest;
    }
}
