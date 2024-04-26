namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57D3066E887D23C9, NameHash = 0x73F04336E773575A)]
    public class GcMissionConditionHasWeapons : NMSTemplate
    {
        // size: 0x4
        public enum WeaponTestEnum : uint {
            CombatPrimaryEquipped,
            CombatSecondaryEquipped,
            CombatPrimaryInstalled,
            CombatSecondaryInstalled,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WeaponTestEnum WeaponTest;
    }
}
