using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2D0, GUID = 0x8E8D1FE2022A3EA3, NameHash = 0xB82C2871716786E2)]
    public class GcUniqueNPCSpawnData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x10 PresetId;
        /* 0x020 */ public GcResourceElement ResourceElement;

        /* 0x2C8 */ public GcAlienRace Race;
        [NMS(Size = 4, Ignore = true)]
        /* 0x2CC */ public byte[] EndPadding;

    }
}
