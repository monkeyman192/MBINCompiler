using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3750322D673A2913, NameHash = 0x505F7128834EAACA)]
    public class GcCreatureVocalData : NMSTemplate
    {
        public float ScaleBias;

        public GcCreatureVocalSoundData IdleVocal;
        public GcCreatureVocalSoundData FleeVocal;
        public GcCreatureVocalSoundData DeathVocal;
        public GcCreatureVocalSoundData AttackVocal;
    }
}