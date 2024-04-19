using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x566A23A483089956, NameHash = 0xAF7590464B3BC984)]
    public class GcRewardDeath : NMSTemplate
    {
        /* 0x00 */ public Colour InitialFadeColour;
        /* 0x10 */ public NMSString0x20A DeathAuthor;
        /* 0x30 */ public NMSString0x20A DeathQuote;
        /* 0x50 */ public NMSString0x10 CameraShake;
        /* 0x60 */ public NMSString0x10 PlayerDamage;
        /* 0x70 */ public Vector2f DeathSpinPitch;
        /* 0x78 */ public Vector2f DeathSpinRoll;
        /* 0x80 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x84 */ public float BlackScreenBeforeQuote;
        /* 0x88 */ public float FadeDuration;
        /* 0x8C */ public GcSeasonSaveStateOnDeath SetSeasonSaveState;
        /* 0x90 */ public float TimeToSpendDead;
        /* 0x94 */ public TkCurveType FadeCurve;
        /* 0x95 */ public bool OverrideShipSpin;
    }
}
