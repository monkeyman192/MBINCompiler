using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x67EFEBE4D5061994, NameHash = 0xAF7590464B3BC984)]
    public class GcRewardDeath : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PlayerDamage;
        /* 0x10 */ public float FadeDuration;
        /* 0x20 */ public Colour InitialFadeColour;
        /* 0x30 */ public TkCurveType FadeCurve;
        /* 0x34 */ public float BlackScreenBeforeQuote;
        /* 0x38 */ public float TimeToSpendDead;
        /* 0x40 */ public NMSString0x20A DeathQuote;
        /* 0x60 */ public NMSString0x20A DeathAuthor;
        /* 0x80 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x84 */ public GcSeasonSaveStateOnDeath SetSeasonSaveState;
        /* 0x88 */ public bool OverrideShipSpin;
        /* 0x8C */ public Vector2f DeathSpinRoll;
        /* 0x94 */ public Vector2f DeathSpinPitch;
        /* 0xA0 */ public NMSString0x10 CameraShake;
    }
}
