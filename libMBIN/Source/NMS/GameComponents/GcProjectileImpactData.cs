using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x9D38BEA536F71877, NameHash = 0x2F2FAFA4A7023B71)]
    public class GcProjectileImpactData : NMSTemplate       // size: 0x18
    {
        /* 0x000 */ public NMSString0x10 Effect;
        /* 0x010 */ public GcProjectileImpactType Impact;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}