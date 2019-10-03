using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2D0, GUID = 0xEFDB839F0CF27F92, NameHash = 0xB82C2871716786E2)]
    public class GcUniqueNPCSpawnData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x10)]
        /* 0x010 */ public string PresetId;
        /* 0x020 */ public GcResourceElement ResourceElement;

        /* 0x2C8 */ public GcAlienRace Race;
        [NMS(Size = 4, Ignore = true)]
        /* 0x2CC */ public byte[] EndPadding;

    }
}
