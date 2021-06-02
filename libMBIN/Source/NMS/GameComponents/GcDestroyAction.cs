using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x58C7698795121554, NameHash = 0xD01AAF2CB5C146A1)]
    public class GcDestroyAction : NMSTemplate
    {
        /* 0x00 */ public bool DestroyAll;
        /* 0x01 */ public bool UseDestructables;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x02 */ public byte[] Padding2;
        /* 0x08 */ public NMSString0x10 PlayEffect;
    }
}