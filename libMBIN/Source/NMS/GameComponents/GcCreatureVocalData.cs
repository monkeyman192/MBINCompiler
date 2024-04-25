using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED0EA1EB716B1C8F, NameHash = 0x505F7128834EAACA)]
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
