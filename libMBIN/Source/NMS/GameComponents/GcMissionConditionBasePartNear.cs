using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, Alignment = 0x8, GUID = 0x6BA9CBE0ED534658, NameHash = 0x12DE4C36058305CA)]
    public class GcMissionConditionBasePartNear : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PartID;
        /* 0x10 */ public float Distance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] EndPadding;
    }
}
