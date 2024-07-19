using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AE4B8AE7DFDACA8, NameHash = 0x72448053)]
    public class GcCreatureVocalData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public GcCreatureVocalSoundData AttackVocal;
        [NMS(Index = 3)]
        /* 0x28 */ public GcCreatureVocalSoundData DeathVocal;
        [NMS(Index = 2)]
        /* 0x50 */ public GcCreatureVocalSoundData FleeVocal;
        [NMS(Index = 1)]
        /* 0x78 */ public GcCreatureVocalSoundData IdleVocal;
        [NMS(Index = 0)]
        /* 0xA0 */ public float ScaleBias;
    }
}
