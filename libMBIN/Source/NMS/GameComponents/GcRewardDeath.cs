using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x934D5FEB4B082B7, NameHash = 0xA1AB33A5)]
    public class GcRewardDeath : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour InitialFadeColour;
        [NMS(Index = 7)]
        /* 0x10 */ public NMSString0x20A DeathAuthor;
        [NMS(Index = 6)]
        /* 0x30 */ public NMSString0x20A DeathQuote;
        [NMS(Index = 13)]
        /* 0x50 */ public NMSString0x10 CameraShake;
        [NMS(Index = 0)]
        /* 0x60 */ public NMSString0x10 PlayerDamage;
        [NMS(Index = 12)]
        /* 0x70 */ public Vector2f DeathSpinPitch;
        [NMS(Index = 11)]
        /* 0x78 */ public Vector2f DeathSpinRoll;
        [NMS(Index = 8)]
        /* 0x80 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 4)]
        /* 0x84 */ public float BlackScreenBeforeQuote;
        [NMS(Index = 1)]
        /* 0x88 */ public float FadeDuration;
        [NMS(Index = 9)]
        /* 0x8C */ public GcSeasonSaveStateOnDeath SetSeasonSaveState;
        [NMS(Index = 5)]
        /* 0x90 */ public float TimeToSpendDead;
        [NMS(Index = 3)]
        /* 0x94 */ public TkCurveType FadeCurve;
        [NMS(Index = 10)]
        /* 0x95 */ public bool OverrideShipSpin;
    }
}
