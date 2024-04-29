using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0C33D96BDD457AE, NameHash = 0x2AF78E5732410B4F)]
    public class GcMultitoolData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public GcInWorldUIScreenData ScreenData;
        [NMS(Index = 10)]
        /* 0x030 */ public GcResourceElement Resource;
        [NMS(Index = 1)]
        /* 0x2D8 */ public GcInventoryContainer Store;
        [NMS(Index = 4)]
        /* 0x430 */ public GcCharacterCustomisationData CustomisationData;
        [NMS(Index = 0)]
        /* 0x478 */ public GcInventoryLayout Layout;
        [NMS(Index = 3)]
        /* 0x490 */ public GcSeed Seed;
        [NMS(Index = 7)]
        /* 0x4A0 */ public int PrimaryMode;
        [NMS(Index = 8)]
        /* 0x4A4 */ public int SecondaryMode;
        [NMS(Index = 5)]
        /* 0x4A8 */ public NMSString0x20 Name;
        [NMS(Index = 6)]
        /* 0x4C8 */ public bool IsLarge;
        [NMS(Index = 9)]
        /* 0x4C9 */ public bool UseLegacyColours;
    }
}
