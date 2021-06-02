using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xD5F1AEB0209042C6, NameHash = 0x36320600C6ADE7CA)]
    public class GcSpawnDensity : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Name;
        /* 0x010 */ public bool Active;
		[NMS(Size = 3, Ignore = true)]
        /* 0x011 */ public byte[] Padding011;
		public enum CoverageTypeEnum { Total, SmoothPatch, GridPatch }
		public CoverageTypeEnum CoverageType;

        /* 0x018 */ public float PatchSize;
        /* 0x01C */ public float RegionScale;
    }
}