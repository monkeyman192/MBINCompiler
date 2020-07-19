using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, Size = 0x30, GUID = 0x7A47BED677C37D37, NameHash = 0x28EDE156F726CF4C)]
    public class GcRewardProceduralProduct : NMSTemplate
    {
        /* 0x00 */ public GcProceduralProductCategory Type;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        [NMS(Size = 0x20)]
        /* 0x08 */ public string OSDMessage;
        /* 0x28 */ public bool SubIfPlayerAlreadyHasOne;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x29 */ public byte[] EndPadding;
    }
}
