using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x48AC5185DE3A1C62, NameHash = 0x1B068ED405386448)]
    public class GcMissionConditionHasProcTechnology : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 ProcTechGroupID;
        /* 0x20 */ public int Count;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
