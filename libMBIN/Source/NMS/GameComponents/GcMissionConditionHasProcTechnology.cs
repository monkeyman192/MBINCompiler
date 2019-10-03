using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x48AC5185DE3A1C62, NameHash = 0x1B068ED405386448)]
    public class GcMissionConditionHasProcTechnology : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string ProcTechGroupID;
        /* 0x20 */ public int Count;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] EndPadding;
    }
}
