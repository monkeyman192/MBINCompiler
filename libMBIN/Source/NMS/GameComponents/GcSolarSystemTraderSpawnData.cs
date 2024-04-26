namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A9EA671BB4E86D8, NameHash = 0x436337B25B8F877E)]
    public class GcSolarSystemTraderSpawnData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector2f SequenceTakeoffDelay;
        [NMS(Index = 3)]
        /* 0x08 */ public int ChanceToDelayLaunch;
        [NMS(Index = 1)]
        /* 0x0C */ public float InitialTakeoffDelay;
        [NMS(Index = 0)]
        /* 0x10 */ public int MaxToSpawn;
    }
}
