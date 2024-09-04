namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F987993156F2B09, NameHash = 0xE6052335)]
    public class GcCreatureJellyBossAttackData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x0 */ public float MaxIdleRange;
        [NMS(Index = 4)]
        /* 0x4 */ public float MinIdleRange;
        [NMS(Index = 3)]
        /* 0x8 */ public float SpawnTimer;
        [NMS(Index = 0)]
        /* 0xC */ public bool CanSpawnJellies;
        [NMS(Index = 2)]
        /* 0xD */ public bool ExplodeOnPlayer;
        [NMS(Index = 1)]
        /* 0xE */ public bool UseElectroAttack;
    }
}
