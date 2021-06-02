using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, GUID = 0xF63AD61FDA9AB477, NameHash = 0xB85371DB04FCCA0)]
    public class GcMissionSequenceGatherForBuild : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 TargetTech;
        /* 0x090 */ public NMSString0x10 GatherResource;
        /* 0x0A0 */ public NMSString0x80 DebugText;
    }
}