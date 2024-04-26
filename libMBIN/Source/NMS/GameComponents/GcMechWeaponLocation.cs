namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36DF5247EE372E6D, NameHash = 0x87D2DB7CF99E11A4)]
    public class GcMechWeaponLocation : NMSTemplate
    {
        // size: 0x4
        public enum MechWeaponLocationEnum : uint {
            TurretExocraft,
            TurretSentinel,
            ArmLeft,
            ArmRight,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MechWeaponLocationEnum MechWeaponLocation;
    }
}
