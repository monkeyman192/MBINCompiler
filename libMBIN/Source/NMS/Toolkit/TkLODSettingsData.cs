using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x74, GUID = 0xC948338CC90E374, NameHash = 0xA0C253D5A5EF8A51)]
    public class TkLODSettingsData : NMSTemplate
    {
        [NMS(Size = 5)]
        /* 0x00 */ public float[] LODAdjust;
        [NMS(Size = 0x6)]
        /* 0x14 */ public int[] ImposterOverrideRange;
        [NMS(Size = 0x6)]
        /* 0x2C */ public int[] MaxObjectDistanceOverride;
        [NMS(Size = 0x6)]
        /* 0x44 */ public int[] RegionLODHiddenRanges;
        [NMS(Size = 0x6)]
        /* 0x5C */ public int[] RegionLODRadius;
    }
}
