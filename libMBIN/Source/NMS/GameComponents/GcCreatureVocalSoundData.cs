using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcCreatureVocalSoundData : NMSTemplate
    {
        public NMSString0x10 Id;

        public int VocalEmote;
        public string[] VocalEmoteValues()
        {
            return new[] { "EmoteIdle", "EmoteFlee", "EmoteAggression", "EmoteRoar", "EmotePain", "EmoteAttack", "EmoteDie", "EmoteMiniRoarNeutral", "EmoteMiniRoarHappy", "EmoteMiniRoarAngry" };
        }

        public float PlayFrequency;
        public float MinCooldown;
        public float MaxCooldown;
        public bool PlayImmediately;
        public bool PlayOnlyOnce;

        [NMS(Size = 6, Ignore = true)]
        public byte[] Padding22;
    }
}
