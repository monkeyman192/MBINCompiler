using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3487CE238D8DA65, NameHash = 0x7C3FC7921ED5983A)]
    public class GcReplacementEffectData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public NMSString0x10 ReplaceWith;
    }
}
