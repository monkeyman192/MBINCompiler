namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC75E9B9C8ED95CD4, NameHash = 0x2BFE76ABF5398879)]
    public class GcGameMode : NMSTemplate
    {
        // size: 0x7
        public enum PresetGameModeEnum : uint {
            Unspecified,
            Normal,
            Creative,
            Survival,
            Ambient,
            Permadeath,
            Seasonal,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PresetGameModeEnum PresetGameMode;
    }
}
