using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED0EA1EB716B1C8F, NameHash = 0x505F7128834EAACA)]
    public class GcCreatureVocalData : NMSTemplate
    {
        /* 0x00 */ public GcCreatureVocalSoundData AttackVocal;
        /* 0x28 */ public GcCreatureVocalSoundData DeathVocal;
        /* 0x50 */ public GcCreatureVocalSoundData FleeVocal;
        /* 0x78 */ public GcCreatureVocalSoundData IdleVocal;
        /* 0xA0 */ public float ScaleBias;
    }
}
