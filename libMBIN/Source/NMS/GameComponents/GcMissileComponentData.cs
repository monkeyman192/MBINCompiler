using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3084C666AE66E619, NameHash = 0x342DA8D8BE5A9CE3)]
    public class GcMissileComponentData : NMSTemplate       // size: 0x28
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
		/* 0x010 */ public float NoTargetLife;
        [NMS(Size = 0x10)]
		/* 0x018 */ public string Trail;
	}
}