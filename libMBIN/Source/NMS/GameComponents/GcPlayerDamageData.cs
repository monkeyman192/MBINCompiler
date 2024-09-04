using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B9EA0D6D0895675, NameHash = 0x9776BBFB)]
    public class GcPlayerDamageData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public NMSString0x20A CriticalHitMessage;
        [NMS(Index = 1)]
        /* 0x020 */ public NMSString0x20A DeathMessage;
        [NMS(Index = 4)]
        /* 0x040 */ public NMSString0x20A HitChatMessage;
        [NMS(Index = 5)]
        /* 0x060 */ public NMSString0x20A HitMessage;
        [NMS(Index = 3)]
        /* 0x080 */ public TkTextureResource HitIcon;
        [NMS(Index = 13)]
        /* 0x098 */ public NMSString0x10 CameraShakeNoShield;
        [NMS(Index = 12)]
        /* 0x0A8 */ public NMSString0x10 CameraShakeShield;
        [NMS(Index = 18)]
        /* 0x0B8 */ public List<GcBreakTechByStatData> DamageTechWithStat;
        [NMS(Index = 2)]
        /* 0x0C8 */ public NMSString0x10 DeathStat;
        [NMS(Index = 0)]
        /* 0x0D8 */ public NMSString0x10 Id;
        [NMS(Index = 11)]
        /* 0x0E8 */ public float CameraTurn;
        [NMS(Index = 8)]
        /* 0x0EC */ public GcAudioWwiseEvents CriticalHitMessageAudio;
        [NMS(Index = 9)]
        /* 0x0F0 */ public float Damage;
        [NMS(Index = 6)]
        /* 0x0F4 */ public GcAudioWwiseEvents HitMessageAudio;
        // size: 0x5
        public enum PlayerDamageTypeEnum : uint {
            Normal,
            Toxic,
            Radioactive,
            Freeze,
            Scorch,
        }
        [NMS(Index = 17)]
        /* 0x0F8 */ public PlayerDamageTypeEnum PlayerDamageType;
        [NMS(Index = 10)]
        /* 0x0FC */ public float PushForce;
        [NMS(Index = 19)]
        /* 0x100 */ public float TechDamageChance;
        [NMS(Index = 16)]
        /* 0x104 */ public bool AllowDeathInInteraction;
        [NMS(Index = 15)]
        /* 0x105 */ public bool ForceDamageInInteraction;
        [NMS(Index = 14)]
        /* 0x106 */ public bool ShowTrackIcon;
    }
}
