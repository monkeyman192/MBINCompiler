namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7EECD09781E1870, NameHash = 0xF554DC208673EE3D)]
    public class GcBeenShotEvent : NMSTemplate
    {
        /* 0x0 */ public int DamageThreshold;
        /* 0x4 */ public float HealthThreshold;
        // size: 0x3
        public enum ShotByEnum : uint {
            Player,
            Anything,
            PlayerOrRemotePlayer,
        }
        /* 0x8 */ public ShotByEnum ShotBy;
    }
}
