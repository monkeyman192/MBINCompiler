using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x48AC5185DE3A1C62, NameHash = 0x1B068ED405386448)]
    public class GcMissionConditionHasProcTechnology : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A ProcTechGroupID;
        /* 0x20 */ public int Count;
    }
}
