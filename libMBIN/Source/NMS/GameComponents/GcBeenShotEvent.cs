namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7EECD09781E1870, NameHash = 0xF554DC208673EE3D)]
    public class GcBeenShotEvent : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int DamageThreshold;
        [NMS(Index = 2)]
        /* 0x4 */ public float HealthThreshold;
        // size: 0x3
        public enum ShotByEnum : uint {
            Player,
            Anything,
            PlayerOrRemotePlayer,
        }
        [NMS(Index = 0)]
        /* 0x8 */ public ShotByEnum ShotBy;
    }
}
