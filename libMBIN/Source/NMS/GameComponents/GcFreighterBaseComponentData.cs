using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x885CB5F8C0E58A92, NameHash = 0x8201F7ADD0F5959D)]
    public class GcFreighterBaseComponentData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x00 */ public GcFreighterBaseOptions[] FreighterBaseOptions;
        // size: 0x2
        public enum FreighterBaseGenerationModeEnum : uint {
            Prefab,
            WFC,
        }
        [NMS(Index = 0)]
        /* 0x40 */ public FreighterBaseGenerationModeEnum FreighterBaseGenerationMode;
        [NMS(Index = 2)]
        /* 0x44 */ public NMSString0x80 FreighterBaseForPlayerReset;
        [NMS(Index = 3)]
        /* 0xC4 */ public NMSString0x80 WFCBuildingFile;
    }
}
