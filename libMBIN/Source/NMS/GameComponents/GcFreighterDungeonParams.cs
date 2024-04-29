using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A41A5B71F3E2D17, NameHash = 0x1186D86C82D48E4E)]
    public class GcFreighterDungeonParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcDungeonGenerationParams DungeonParams;
        [NMS(Index = 0)]
        /* 0x80 */ public NMSString0x10 Name;
    }
}
