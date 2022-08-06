using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x98BF723C39B6BB58, NameHash = 0x8201F7ADD0F5959D)]
    public class GcFreighterBaseComponentData : NMSTemplate
    {
        public enum FreighterBaseGenerationModeEnum { Prefab, WFC }
        /* 0x00 */ public FreighterBaseGenerationModeEnum FreighterBaseGenerationMode;
        [NMS(Size = 0x4)]
        /* 0x08 */ public GcFreighterBaseOptions[] FreighterBaseOptions;
        /* 0x48 */ public NMSString0x80 FreighterBaseForPlayerReset;
        /* 0xC8 */ public NMSString0x80 WFCBuildingFile;
    }
}
