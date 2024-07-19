namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3FB56BD630AFD63, NameHash = 0xD39E1ECF)]
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
