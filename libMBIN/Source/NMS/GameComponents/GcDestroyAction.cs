using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x58C7698795121554, NameHash = 0xD01AAF2CB5C146A1)]
    public class GcDestroyAction : NMSTemplate
    {
        /* 0x00 */ public bool DestroyAll;
        /* 0x01 */ public bool UseDestructables;
        /* 0x08 */ public NMSString0x10 PlayEffect;
    }
}