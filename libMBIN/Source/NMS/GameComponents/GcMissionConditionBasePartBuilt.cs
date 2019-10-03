using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, Alignment = 0x8, GUID = 0x6F99E641DA91FA97, NameHash = 0x75A4AF2BCC689FD2)]
    public class GcMissionConditionBasePartBuilt : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string PartID;
        /* 0x10 */ public int Count;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        /* 0x18 */ public GcBuildingPartSearchType Type;
		public enum PartInCurrentBaseEnum { DontCare, YesAllPlayerOwned }
		/* 0x38 */ public PartInCurrentBaseEnum PartInCurrentBase;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3C */ public byte[] EndPadding;
    }
}
