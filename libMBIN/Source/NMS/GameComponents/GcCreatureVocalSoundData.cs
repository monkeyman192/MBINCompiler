using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xFE1CDC6167AE7D3B, NameHash = 0x7FE7156AA587561F)]
    public class GcCreatureVocalSoundData : NMSTemplate
    {
        public NMSString0x10 Id;

		public enum VocalEmoteEnum { EmoteIdle, EmoteFlee, EmoteAggression, EmoteRoar, EmotePain, EmoteAttack, EmoteDie, EmoteMiniRoarNeutral, EmoteMiniRoarHappy, EmoteMiniRoarAngry }
		public VocalEmoteEnum VocalEmote;

        public float PlayFrequency;
        public float MinCooldown;
        public float MaxCooldown;
        public bool PlayImmediately;
        public bool PlayOnlyOnce;

        [NMS(Size = 6, Ignore = true)]
        public byte[] Padding22;
    }
}