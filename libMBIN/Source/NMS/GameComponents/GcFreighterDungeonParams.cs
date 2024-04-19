using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0D3F2E5C001BA81, NameHash = 0x1186D86C82D48E4E)]
    public class GcFreighterDungeonParams : NMSTemplate
    {
        /* 0x00 */ public GcDungeonGenerationParams DungeonParams;
        /* 0x80 */ public NMSString0x10 Name;
    }
}
