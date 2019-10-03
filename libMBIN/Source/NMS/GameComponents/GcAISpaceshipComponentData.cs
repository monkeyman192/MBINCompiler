using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x94, GUID = 0xD0D3DF28AB69CAAF, NameHash = 0x4F5433BCFC028B49)]
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        /* 0x00 */ public GcAISpaceshipTypes Type;
        /* 0x04 */ public GcSpaceshipClasses Class;
        /* 0x08 */ public GcPrimaryAxis Axis;
        /* 0x0C */ public TkTextureResource Hangar;
        /* 0x90 */ public bool IsSpaceAnomaly;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x91 */ public byte[] EndPadding;
    }
}
