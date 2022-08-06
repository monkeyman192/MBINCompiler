using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC227EED70BB33F53, NameHash = 0x93C5F18EADCD6C3C)]
    public class GcGroundWormComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x100 LookJoint;
        /* 0x100 */ public NMSString0x100 GrabJoint;
        /* 0x200 */ public NMSString0x10 EmergeEffect;
        /* 0x210 */ public NMSString0x10 SubmergeEffect;
        /* 0x220 */ public NMSString0x10 EmergeShake;
        /* 0x230 */ public NMSString0x10 RoarShake;
        /* 0x240 */ public float CollisionBodySize;
        /* 0x244 */ public float RumbleTime;
        /* 0x248 */ public float EmergeEffectTime;
        /* 0x24C */ public float EmergeDist;
        /* 0x250 */ public float SubmergeDist;
        /* 0x254 */ public float SubmergeDepth;
        /* 0x258 */ public float FlinchTime;
        /* 0x25C */ public float FlinchAngleMin;
        /* 0x260 */ public float FlinchAngleMax;
        /* 0x264 */ public float FlinchSmooth;
        /* 0x268 */ public NMSString0x10 AttackDamageType;
        /* 0x278 */ public float AttackDamageRadius;
        /* 0x27C */ public float AttackAngle;
        /* 0x280 */ public float AttackDistMin;
        /* 0x284 */ public float AttackDistMax;
        /* 0x288 */ public float AttackCooldown;
        /* 0x28C */ public float RoarCooldown;
        /* 0x290 */ public float LungeStrength;
        /* 0x294 */ public float LungeAngleHead;
        /* 0x298 */ public float LungeAngleBase;
        /* 0x29C */ public float LungeBeginTime;
        /* 0x2A0 */ public float LungeEndTime;
        /* 0x2A4 */ public float LungeBlendInSpeed;
        /* 0x2A8 */ public float LungeBlendOutSpeed;
        /* 0x2AC */ public float WindUpStrength;
        /* 0x2B0 */ public float WindUpAngleHead;
        /* 0x2B4 */ public float WindUpAngleBase;
        /* 0x2B8 */ public float RestTime;
        /* 0x2BC */ public float TrackTime;
        /* 0x2C0 */ public float TurnSpeed;
        /* 0x2C4 */ public float EmergeLookBlendStart;
        /* 0x2C8 */ public float EmergeLookBlendEnd;
        /* 0x2CC */ public float EmergeTime;
        /* 0x2D0 */ public float RearUpBeginDist;
        /* 0x2D4 */ public float RearUpEndDist;
    }
}
