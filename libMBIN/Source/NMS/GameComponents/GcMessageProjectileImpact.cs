using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x50, GUID = 0x9C6FF0332EAD43B3, NameHash = 0x7EBC25FE326CF24B)]
    public class GcMessageProjectileImpact: NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int Damage;
        /* 0x14 */ public GcDamageType Type;
        /* 0x18 */ public bool Critical;
        /* 0x19 */ public bool Ineffective;
        /* 0x1A */ public bool LaserHeatBoost;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x1B */ public byte[] Padding1B;     // Not sure why there is this here...
        public enum HitTypeEnum { Shootable, Terrain, Generic }
        /* 0x20 */ public HitTypeEnum HitType;
        /* 0x30 */ public Vector3f PosLocal;
        /* 0x40 */ public Vector3f PosOffset;
    }
}
