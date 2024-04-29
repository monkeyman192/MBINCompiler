namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44CF43712D4A24F9, NameHash = 0x7FE7156AA587561F)]
    public class GcCreatureVocalSoundData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 4)]
        /* 0x10 */ public float MaxCooldown;
        [NMS(Index = 3)]
        /* 0x14 */ public float MinCooldown;
        [NMS(Index = 2)]
        /* 0x18 */ public float PlayFrequency;
        // size: 0xA
        public enum VocalEmoteEnum : uint {
            EmoteIdle,
            EmoteFlee,
            EmoteAggression,
            EmoteRoar,
            EmotePain,
            EmoteAttack,
            EmoteDie,
            EmoteMiniRoarNeutral,
            EmoteMiniRoarHappy,
            EmoteMiniRoarAngry,
        }
        [NMS(Index = 1)]
        /* 0x1C */ public VocalEmoteEnum VocalEmote;
        [NMS(Index = 5)]
        /* 0x20 */ public bool PlayImmediately;
        [NMS(Index = 6)]
        /* 0x21 */ public bool PlayOnlyOnce;
    }
}
