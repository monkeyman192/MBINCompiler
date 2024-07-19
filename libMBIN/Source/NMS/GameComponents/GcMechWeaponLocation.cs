namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE2B189DD039F4B3, NameHash = 0xE5333E32)]
    public class GcMechWeaponLocation : NMSTemplate
    {
        // size: 0x5
        public enum MechWeaponLocationEnum : uint {
            TurretExocraft,
            TurretSentinel,
            ArmLeft,
            ArmRight,
            FlameThrower,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MechWeaponLocationEnum MechWeaponLocation;
    }
}
