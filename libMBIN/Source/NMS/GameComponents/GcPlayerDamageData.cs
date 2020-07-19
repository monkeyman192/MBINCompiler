using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x140, GUID = 0x2D6DDB2CFF7DAEA8, NameHash = 0x5F9BF82F9925D932)]
    public class GcPlayerDamageData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x20)]
        /* 0x010 */ public string DeathMessage;
        [NMS(Size = 0x10)]
        /* 0x030 */ public string DeathStat;
        /* 0x040 */ public TkTextureResource HitIcon;
        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingC4;
        [NMS(Size = 0x20)]
        /* 0x0C8 */ public string HitMessage;
        [NMS(Size = 0x20)]
        /* 0x0E8 */ public string CriticalHitMessage;
        /* 0x108 */ public float Damage;
        /* 0x10C */ public float HardModeMultiplier;
        /* 0x110 */ public float PushForce;
        /* 0x114 */ public float CameraTurn;
        [NMS(Size = 0x10)]
        /* 0x118 */ public string CameraShakeShield;
        [NMS(Size = 0x10)]
        /* 0x128 */ public string CameraShakeNoShield;
        /* 0x138 */ public bool ShowTrackIcon;
        /* 0x139 */ public bool ForceDamageInInteraction;
		public enum PlayerDamageTypeEnum { Normal, Toxic, Radioactive, Freeze, Scorch }
		/* 0x13C */ public PlayerDamageTypeEnum PlayerDamageType;
    }
}
