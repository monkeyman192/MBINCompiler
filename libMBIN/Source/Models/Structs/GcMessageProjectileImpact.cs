namespace libMBIN.Models.Structs
{
    public class GcMessageProjectileImpact: NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public int Damage;
        /* 0x14 */ public GcDamageType Type;
        /* 0x18 */ public bool Critical;
        /* 0x19 */ public bool Ineffective;
        /* 0x1C */ public int HitType;
        public string[] HitTypeValues()
        {
            return new[] {"Shootable", "Terrain", "Generic"};
        }
        [NMS(Size = 0x10, Ignore = true)]
        /* 0x20 */ public byte[] Padding20;     // ???
        /* 0x30 */ public Vector4f PosLocal;
        /* 0x40 */ public Vector4f PosOffset;
    }
}
